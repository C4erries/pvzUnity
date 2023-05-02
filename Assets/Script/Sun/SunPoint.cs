using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SunPoint : MonoBehaviour
{
    public float speed = 1f;
    public float deadSunTimeout;
    public float point;
    private void Start()
    {
        deadSunTimeout = 10.0f;
        StartCoroutine(Counter());
    }
    private void Awake()
    {
        point = Random.Range(100, 350);
        GetComponent<Rigidbody2D>().transform.position = new Vector3(Random.Range(250, 650), 580, 0);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed * -100);
    }
    private void Update()
    {
        if(GetComponent<Rigidbody2D>().position.y <= point)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
        
    }
    private IEnumerator Counter()
    {
        yield return new WaitForSeconds(deadSunTimeout);
        Destroy(this.gameObject);
    }
    public void OnButtonDown()
    {
        SunWallet.sunCounter += 100;
        Destroy(this.gameObject);
    }
}
