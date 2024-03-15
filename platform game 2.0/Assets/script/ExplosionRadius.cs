using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class ExplosionRadius : MonoBehaviour
{
    [SerializeField] private string tag = "breakable"; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has the "breakable" tag
        if (other.CompareTag(tag))
        {
            // Destroy the collided object
            Destroy(other.gameObject);
            GameObject parentObject = transform.parent.gameObject;
        
            // Destroy the parent GameObject
            Destroy(parentObject);
        }
    }
}