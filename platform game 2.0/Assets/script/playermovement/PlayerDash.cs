using System.Collections;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float dashForce = 10f; // Customize dash force here
    public float dashDuration = 0.1f; // Duration of the dash
    public float dashCooldown = 1f; // Cooldown between dashes
    private bool canDash = true;

    private PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (canDash && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Dash initiated.");
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("Dash left.");
                StartCoroutine(Dash(-dashForce));
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("Dash right.");
                StartCoroutine(Dash(dashForce));
            }
        }
    }

    IEnumerator Dash(float direction)
    {
        canDash = false;
        playerMovement.enabled = false; // Disable PlayerMovement while dashing

        // Apply the dash force
        playerMovement.rb.velocity = new Vector2(direction, playerMovement.rb.velocity.y);

        // Wait for dash duration
        yield return new WaitForSeconds(dashDuration);

        // Reset velocity after dash duration
        playerMovement.rb.velocity = new Vector2(0f, playerMovement.rb.velocity.y);

        // Wait for dash cooldown
        yield return new WaitForSeconds(dashCooldown);

        playerMovement.enabled = true; // Re-enable PlayerMovement
        canDash = true;
    }
}