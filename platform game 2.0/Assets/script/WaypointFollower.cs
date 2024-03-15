using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    // Een array van waypoints die het object zal volgen
    [SerializeField] private GameObject[] Waypoints;

    // De index van het huidige waypoint waar het object naartoe beweegt
    private int currentWaypointIndex = 0;

    // De snelheid waarmee het object naar de waypoints zal bewegen
    [SerializeField] private float speed = 2f;

    // Update wordt één keer per frame opgeroepen
    void Update()
    {
        // Als het object het huidige waypoint heeft bereikt
        if (Vector2.Distance(Waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            // Ga naar het volgende waypoint
            currentWaypointIndex++;

            // Als we aan het einde van de waypoints-array zijn gekomen, ga dan terug naar het begin
            if (currentWaypointIndex >= Waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        // Beweeg het object naar het huidige waypoint
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
