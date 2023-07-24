using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 playerPos = player.transform.position;

        if (playerPos.y <= 4 && playerPos.y >= -4)
        {
            transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
        }
    }
}
