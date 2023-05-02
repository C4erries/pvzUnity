using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Zombie : mainzombie
{
    private Rigidbody2D rb;

    void Start()
    {
        hp = 100f;
        vel = 25f;
        rb= GetComponent<Rigidbody2D>();
        colr = this.gameObject.GetComponent<Image>();
    }


    void FixedUpdate()
    {
        if (!stop)
        {
            rb.velocity = new Vector2(-vel, 0);
            colr.color = Color.white;
        }
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("stay");
        if (col.gameObject.CompareTag("plant"))
        {
            stop = true;
            rb.velocity = Vector2.zero;
            Debug.Log(Time.time-lastbite);
            if ((Time.time - lastbite) >= 0.4f)
            {
                Debug.Log("Got it");
                if (colr.color == Color.white)
                {
                    colr.color = new Color(0.8f, 0.8f, 0.8f, 1f);
                }
                else
                {
                    colr.color = Color.white;
                }
                col.gameObject.GetComponent<mainplant>().hp -= 10;
                lastbite=Time.time;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("plant"))
        {
            stop = false;
        }
    }
}
