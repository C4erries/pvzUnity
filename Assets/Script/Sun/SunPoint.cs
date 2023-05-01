using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPoint : MonoBehaviour
{
    public float speed = 1f;
    public SunManager sunManager;
    private void Start()
    {
        sunManager = SunManager.instance;
    }
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed*-100);
    }
    public void OnButtonDown()
    {
        SunWallet.sunCounter += 100;
        Destroy(this.gameObject);
    }
}
