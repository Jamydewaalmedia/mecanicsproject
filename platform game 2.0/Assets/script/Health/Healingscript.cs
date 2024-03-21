using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healingscript : MonoBehaviour
{
    [SerializeField] private HealthManager healthManager;
    [SerializeField] private float delayedtime; 

// Start is called before the first frame update
    void Start()
    {
        // Find the GameObject named "HealthManager" in the scene
        GameObject healthManagerGameObject = GameObject.Find("HealthManager");

        if (healthManagerGameObject != null)
        {
            // Attempt to get the HealthManager component attached to the found GameObject
            healthManager = healthManagerGameObject.GetComponent<HealthManager>();

            if (healthManager == null)
            {
                // If HealthManager component is not found, log an error
                Debug.LogError("HealthManager component not found on the GameObject named 'HealthManager'");
            }
        }
        else
        {
            // If GameObject named "HealthManager" is not found, log an error
            Debug.LogError("GameObject named 'HealthManager' not found in the scene");
        }
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.DelayedAction(delayedtime, () =>
        {
            healthManager.AddHealty(20f);
            Destroy(gameObject);
            // Put your code here that you want to execute after the delay
        });
       
    }
    
}
