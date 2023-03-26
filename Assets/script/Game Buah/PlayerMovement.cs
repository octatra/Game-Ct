using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    Rigidbody2D rb;

    public GameObject Spawn;
    public GameObject Info;
    public GameObject Joystick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Spawn.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        float Horiz = SimpleInput.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Horiz * Speed, rb.velocity.y);
    }

    public void StartSpanw()
    {
        Spawn.SetActive(true);
        Info.SetActive(false);
        Joystick.SetActive(true);
    }
}
