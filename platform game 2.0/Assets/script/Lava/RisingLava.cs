using UnityEngine;

public class RisingLava : MonoBehaviour
{
    public float riseSpeed = 2f; // Speed at which the lava rises per second
    public string lavaTag = "Lava"; // Tag assigned to the lava objects

    private void Update()
    {
        // Find all game objects with the specified tag
        GameObject[] lavaObjects = GameObject.FindGameObjectsWithTag(lavaTag);

        // Move each lava object upwards
        foreach (GameObject lavaObject in lavaObjects)
        {
            // Calculate the amount to move based on riseSpeed and Time.deltaTime
            float moveAmount = riseSpeed * Time.deltaTime;

            // Move the lava object upwards
            lavaObject.transform.Translate(Vector3.up * moveAmount, Space.World);
        }
    }
}