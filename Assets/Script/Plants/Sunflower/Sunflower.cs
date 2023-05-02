using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflower : mainplant
{
    public GameObject FlowerSun;
    private Canvas canvas;
    public float rate = 5.0f;
    public float gain = 50f;
    void Start()
    {
        canvas = GetComponentInParent<Canvas>();
        { InvokeRepeating("Deployer", rate, rate); }
    }

    private void Update()
    {
        if (hp <= 0f)
        {
            GetComponentInParent<ObjectContainer>().isFull = false;
            Destroy(this.gameObject);
        }
    }
    private void Deployer()
    {
        Instantiate(FlowerSun, this.gameObject.transform.position, new Quaternion(),canvas.transform);
    }
}
