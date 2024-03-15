using UnityEngine;

public class Platformstick : MonoBehaviour
{
    [SerializeField] private string targetTag = "Player";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the specified tag
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Stick the object with the specified tag to the platform
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the colliding object has the specified tag
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Release the object with the specified tag from the platform
            collision.gameObject.transform.SetParent(null);
        }
    }
}