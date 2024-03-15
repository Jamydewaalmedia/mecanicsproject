using System;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject prefabToInstantiate; // Het prefab om te instantiëren
    private bool playerCollided = false; // Een variabele om bij te houden of de speler al heeft gebotst

    void Update()
    {
       
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
            UseChest();
   
    }

    void UseChest()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (prefabToInstantiate == null)
            {
                Debug.Log("Prefab om te instantiëren is niet toegewezen in de inspector!");
                return;
            }

            // Instantieer het prefab op dezelfde positie als dit GameObject
            Instantiate(prefabToInstantiate, transform.position, transform.rotation);

            // Vernietig dit GameObject
            Destroy(gameObject);
        }
    }
}