using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Move
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        Vector3 position = transform.position;
        Vector3 nextpos = new Vector3(h*Time.smoothDeltaTime, v*Time.smoothDeltaTime, 0) * speed;

        transform.position = position + nextpos;

        //animation
        if (Input.GetButtonDown("Vertical") || Input.GetButtonUp("Vertical"))
        {
            anim.SetInteger("Input", (int)v);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Earth")
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
    
}
