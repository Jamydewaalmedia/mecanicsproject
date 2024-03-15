using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class HealthManager : MonoBehaviour
{
    public Image healthbar;
    public float HealthAmount = 100f ;
    
    void Start()
    {
        
       
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) 
        {
            TakeDamage(20f);
        }
        
        if (Input.GetKeyDown(KeyCode.K)) 
        {
            AddHealty(20f);
        }
        
        if(healthbar.fillAmount <= 0) 
        {
            Debug.Log("dead");
        }
        
    }
    public void TakeDamage(float Damage)
    {
        HealthAmount -= Damage;
        healthbar.fillAmount = HealthAmount / 100f;
       


    }
    public void AddHealty(float health)
    {
        HealthAmount += health;
        healthbar.fillAmount = HealthAmount / 100f;
       


    }
}
