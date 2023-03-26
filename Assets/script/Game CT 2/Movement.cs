using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float Jump;
    public bool Ground;
    Rigidbody2D rb;
    public int Point;
    public float Horiz;

    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Ground = false;
        Point = 0;
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horiz = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Horiz * Speed, rb.velocity.y);

        Debug.Log(Horiz);

        if (Horiz > 0.01f)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        }
        else if (Horiz < 0)
        {
            transform.localScale = new Vector3(-0.6f, 0.6f, 0.6f);
        }
        Anim.SetBool("Run", Horiz != 0);
        if (Input.GetKeyDown(KeyCode.Space) && Ground)
        {
            rb.velocity = new Vector2(rb.velocity.x, Jump);
            Ground = false;
        }

    }

    public void kanan()
    {
        rb.velocity = new Vector2(Horiz * Speed, rb.velocity.y);
        transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
    }

    public void Kiri()
    {
        rb.velocity = new Vector2(-Horiz * Speed, rb.velocity.y);
        transform.localScale = new Vector3(-0.6f, 0.6f, 0.6f);
    }


    public void TakePoint(int _points)
    {
        Point = Point + _points;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Ground = true;
        }

    }
}
