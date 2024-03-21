using UnityEngine;

public class ObjectManipulator : MonoBehaviour
{
    private GameObject pickedObject; // The object that is picked up

    void Update()
    {
        // Check for key press to pick up object
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("e is pressed");
            if (pickedObject == null)
            {
                Debug.Log("object is null");
                // Check if the object is colliding with the player
                Collider2D[] colliders = Physics2D.OverlapBoxAll(transform.position, new Vector2(1f, 1f), 0f); // Adjust the size as needed

                //foreach (Collider2D collider in colliders)
                //{
                //   if (collider.CompareTag("DestroyableObject"))
                //    {
                //        Debug.Log("collide with tnt");
                //        pickedObject = collider.gameObject;
                //        pickedObject.transform.SetParent(transform);
                //        break;
                //    }
                //}
            }
        }

        // Check for key press to throw object
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (pickedObject != null)
            {
                // Detach the object from the player
                pickedObject.transform.SetParent(null);

                // Apply force to the object
                Rigidbody2D rb = pickedObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.AddForce(transform.right * -10f, ForceMode2D.Impulse); // Adjust force as needed
                }

                // Reset pickedObject
                pickedObject = null;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw the overlap box in the scene view for visualization
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(1f, 1f, 0f));
    }
}