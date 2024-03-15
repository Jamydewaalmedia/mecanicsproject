using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class InventorySystem : MonoBehaviour
{
    private Dictionary<string, int> inventory = new Dictionary<string, int>();
    [SerializeField] private string Item;
    [SerializeField] private GameObject watermelon;

    public void Start()
    {
        
    }

    public void Update()
    {
    watmellonspawner();

        if (Input.GetKeyDown(KeyCode.T))
        {
            PrintInventory();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(("collectible")))
        {
            AddItem(Item);
            Destroy(other.gameObject);
            

        }
    }

    public void watmellonspawner()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            for (var i = 0; i < 10; i++)
            {
                Instantiate(watermelon, new Vector3(i * 2.0f, 1, 0), Quaternion.identity);
            }
        }
        
    }

    public void AddItem(string newItem, int amount = 1)
    {
        if (!inventory.ContainsKey(newItem))
        {
            inventory.Add(newItem, 0);
        }
        
        inventory[newItem] += amount;
        

        
    }

    public void UseItem(string Item, int deseading = 1)
    {
        if (inventory.ContainsKey(Item))
        {
            inventory[Item] -= deseading;
           
        }
    }

    public void PrintInventory()
    {
        foreach(KeyValuePair<string,int> currentItem in inventory)
        {
            Debug.Log(currentItem.Key + " : " + currentItem.Value);
        }
           
    }
   


}
