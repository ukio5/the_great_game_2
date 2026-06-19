using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class movmeny : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb;
    float speed = 5f;
    public Animator animator;
    public static bool hodit = false;
    public GameObject pCam;
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        pCam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
    }

    void Update()
    {
        if (rb != null)
        {
            animator.SetBool("hodit", hodit);
            Move();
        }
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            hodit = true;
            if (Input.GetKey(KeyCode.A))
            {
                rb.transform.position += Vector3.left * speed * Time.deltaTime;
                rb.transform.localScale = new Vector3(-0.1605818f, 0.1162357f, 1f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.transform.position += Vector3.right * speed * Time.deltaTime;
                rb.transform.localScale = new Vector3(0.1605818f, 0.1162357f, 1f);
            }
        }
        else
        {
            hodit = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.transform.position += Vector3.up * speed * 1.67f * Time.deltaTime;
        }
    }
}
