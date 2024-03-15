using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healingscript : MonoBehaviour
{
    [SerializeField]private HealthManager _healthManager;
    // Start is called before the first frame update
    void Start()
    {
        _healthManager = GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        _healthManager.AddHealty(20f);
    }
}
