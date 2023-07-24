using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float span;
    float delta = 0;

    GameObject earth;

    void Start()
    {
        earth = GameObject.Find("Earth");
    }


    void Update()
    {
        delta += Time.deltaTime;
        Vector3 earthPos = earth.transform.position;

        if(earthPos.x > 13)
        {
            if (delta > span)
            {
                delta = 0;
                GameObject go = Instantiate(enemyPrefab) as GameObject;
                int py = Random.Range(-6, 6);
                go.transform.position = new Vector3(11, py, 0);
            }
        }

    }
}
