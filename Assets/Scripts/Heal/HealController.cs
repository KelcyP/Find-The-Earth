using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(-3f * Time.deltaTime, 0, 0);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject director = GameObject.Find("GameManager");
            director.GetComponent<GameManager>().GetHp();

            Destroy(gameObject);
        }
    }

}
