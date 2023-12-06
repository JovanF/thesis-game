using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController_old : MonoBehaviour
{
    Rigidbody2D theRB;

    public float moveSpeed, jumpForce;

    public Transform groundPoint;
    public LayerMask whatIsGround;

   // private bool isGrounded;
    private float inputX;


    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move the player
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);

        //check if on the ground
       // isGrounded = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);

        //jump the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        }

      /*  if (theRB.velocity.x > 0f)
        {
            transform.localScale = Vector3.one;
        }
        else if (theRB.velocity.x < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }*/
    }

  /*  void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("collect"))
        {         
            SpriteRenderer spriteR;
            spriteR = GetComponent<SpriteRenderer>();
            spriteR.color = new Color(255, 255, 255);
            other.gameObject.SetActive(false);
        }

        else if (other.gameObject.CompareTag("ouch"))
        {

            SpriteRenderer spriteR;
            spriteR = GetComponent<SpriteRenderer>();
            spriteR.color = new Color(255, 0, 0);
        }
    }*/
}




