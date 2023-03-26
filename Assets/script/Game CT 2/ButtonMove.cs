using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool MoveKiri;
    private bool MoveKanan;
    private bool MoveLompat;
    private float horizontalMove;
    public float speed;
    public float Jump;
    public bool Ground;

    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();

        MoveKanan = false;
        MoveKiri = false;
        Ground = false;

        Time.timeScale = 0;
    }

    public void ButtonKiriDitekan()
    {
        MoveKiri = true;
        Anim.SetBool("Run", horizontalMove != 0);
    }

    public void ButtonKananDitekan()
    {
        MoveKanan = true;
    }
    public void ButtonKiriDilepas()
    {
        MoveKiri = false;
    }

    public void ButtonKananDilepas()
    {
        MoveKanan = false;
    }

    public void ButtonLompatDitekan()
    {
        MoveLompat = true;
    }
    public void ButtonLompatDilepas()
    {
        MoveLompat = false;
    }


    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Anim.SetBool("Run", horizontalMove != 0);
    }

    private void MovePlayer()
    {
        if (MoveKiri)
        {
            horizontalMove = -speed;
        }else if (MoveKanan)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
        Anim.SetBool("Run", horizontalMove != 0);

        if (MoveLompat && Ground)
        {
            rb.velocity = new Vector2(rb.velocity.x, Jump);
            Ground = false;
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        }
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);

        if (horizontalMove > 0.01f)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        }
        else if (horizontalMove < 0)
        {
            transform.localScale = new Vector3(-0.6f, 0.6f, 0.6f);
        }
        Anim.SetBool("Run", horizontalMove != 0);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Ground = true;
        }
    }

}
