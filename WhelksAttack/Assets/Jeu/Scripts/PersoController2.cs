using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoController2 : MonoBehaviour
{

    public Animator anim;
    Rigidbody2D rigBody;
    public float jumpForce = 200f;
    public LayerMask theGround;
    public Transform groundCheck;
    bool onTheGround = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        onTheGround = Physics2D.Linecast(transform.position, groundCheck.position, theGround);
        anim.SetBool("InSaut2", onTheGround);
        if (onTheGround && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigBody.AddForce(new Vector2(0, jumpForce));

        }

    }

}
