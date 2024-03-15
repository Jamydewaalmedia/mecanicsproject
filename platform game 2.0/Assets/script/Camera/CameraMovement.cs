using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float value;
    [SerializeField] private float leadDistance = 2f; // Adjust this value to change how much the camera leads the player

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        if (player.transform.position.y > transform.position.y + leadDistance)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = player.transform.position.y - leadDistance;
            transform.position = newPosition;
        }
        else if (player.transform.position.y < transform.position.y)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = player.transform.position.y;
            transform.position = newPosition;
        }
    }
}
