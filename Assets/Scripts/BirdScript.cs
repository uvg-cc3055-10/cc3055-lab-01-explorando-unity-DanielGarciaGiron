using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    private float jumpForce = 200.0f;
    private float forwardSpeed = 2.0f;
    private Rigidbody2D rb;
    public GameObject cam;
    private bool dead = false;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);

            }
            rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        }
        if(rb.transform.position.x >= 45.0f)
        {
            dead = true;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }

}
