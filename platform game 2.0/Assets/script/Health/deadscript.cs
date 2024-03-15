using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadscript : MonoBehaviour
{
    public string tag = "Lava";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has the "breakable" tag
        if (other.CompareTag(tag))
        {
            scenereloader();
            
        }
    }

    public void scenereloader()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
