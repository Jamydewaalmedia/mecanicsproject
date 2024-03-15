using UnityEngine;

public class Laser : MonoBehaviour
{
    public SpriteChanger laserTurret; // Reference to the LaserTurret script on this GameObject
    public string playerTag = "Player"; // Tag of the player GameObject
    private bool playerInside = false;
    public deadscript Deadscript;

    void Start()
    {
        
        if (!laserTurret)
        {
            laserTurret = GetComponent<SpriteChanger>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            playerInside = true;
            if (laserTurret != null && laserTurret.GetCurrentSpriteIndex() == laserTurret.sprites.Length - 1)
            {
                KillPlayer(other.gameObject);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            playerInside = false;
        }
    }

    void KillPlayer(GameObject player)
    {
        // Here you can implement the logic to kill the player
        Debug.Log("Player killed by laser!");
        Deadscript.scenereloader();
    }
}