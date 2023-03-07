using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        //Distroy
        if(transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject director = GameObject.Find("GameManager");
            director.GetComponent<GameManager>().DecreaseHp();

            Destroy(gameObject);
        }
    }

}
