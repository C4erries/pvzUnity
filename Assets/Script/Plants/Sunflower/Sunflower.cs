using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflower : MonoBehaviour
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

    private void Deployer()
    {
        Instantiate(FlowerSun, this.gameObject.transform.position, new Quaternion(),canvas.transform);
    }
}
