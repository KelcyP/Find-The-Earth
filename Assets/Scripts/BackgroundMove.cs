using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    GameObject earth;

    void Start()
    {
        earth = GameObject.Find("Earth");
    }

    void Update()
    {
        Vector3 earthPos = earth.transform.position;

        if(earthPos.x > 0)
        {
            transform.Translate(-1.25f *Time.deltaTime, 0, 0);
        }
    }
}
