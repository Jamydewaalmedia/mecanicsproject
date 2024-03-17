using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class ExplosionRadius : MonoBehaviour
{
    [SerializeField] private string tag = "breakable"; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the "breakable" tag
        if (collision.gameObject.CompareTag(tag))
        {
            // Destroy the collided object
            Destroy(collision.gameObject);
            GameObject parentObject = transform.parent.gameObject;
        
            // Destroy the parent GameObject
            Destroy(parentObject);
        }
    }
}