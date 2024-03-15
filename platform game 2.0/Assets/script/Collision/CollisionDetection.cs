using UnityEngine;

public class CollisionDetection : MonoBehaviour

{
    public string playerTag = "Player";
    public bool playerInside { get; private set; }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            playerInside = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            playerInside = false;
        }
    }
}
