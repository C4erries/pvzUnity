using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private Rigidbody2D rb;
    public float vel;
    public float hp;

    void Start()
    {
        hp = 100f;
        vel = 25f;
        rb= GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(-vel, 0);
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
