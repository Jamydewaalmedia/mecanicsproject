using System;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject prefabToInstantiate; // Het prefab om te instantiëren
    private bool playerCollided = false; // Een variabele om bij te houden of de speler al heeft gebotst
    [SerializeField] private float spawnY = 0;
    [SerializeField] private float spawnX = 0;
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
            Vector3 spawnPosition = transform.position + new Vector3(spawnX, spawnY, 0);
            // Instantieer het prefab op dezelfde positie als dit GameObject
            Instantiate(prefabToInstantiate, spawnPosition , transform.rotation);

            // Vernietig dit GameObject
            Destroy(gameObject);
        }
    }
}