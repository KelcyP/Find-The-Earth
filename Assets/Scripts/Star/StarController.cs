using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 150 * Time.deltaTime);

        transform.Translate(-4f * Time.deltaTime, 0, 0, Space.World);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            GameObject director = GameObject.Find("GameManager");
            director.GetComponent<GameManager>().GetPoint();

            Destroy(gameObject);
        }
    }
}
