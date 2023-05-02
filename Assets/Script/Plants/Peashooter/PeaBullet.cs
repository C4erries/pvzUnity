using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PeaBullet : MonoBehaviour
{
    public float speed;
    public float damage;
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0f);
        if (GetComponent<Rigidbody2D>().transform.position.x >= 900)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("zombie"))
        {
            col.gameObject.GetComponent<mainzombie>().hp -= 10;
            Destroy(this.gameObject);
        }
    }
}
