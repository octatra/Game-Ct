using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bintang : MonoBehaviour
{
    public int Point;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Movement>().TakePoint(Point);
            Destroy(gameObject);
        }
    }
}
