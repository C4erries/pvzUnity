using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PeaBullet : MonoBehaviour
{
    public float speed = 1f;
    public float damage = 10f;

    void Update()
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
            Destroy(this.gameObject);
            col.gameObject.GetComponent<Zombie>().hp -= 10;
        }
    }
}
