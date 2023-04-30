using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peashoter : MonoBehaviour
{
    public GameObject peaBullet;
    public Canvas canvas;
    void Start()
    {
        canvas = this.GetComponentInParent<Canvas>();
        { InvokeRepeating("Shoot", 0, 2.0f); }
    }

    // Update is called once per frame
    private void Shoot()
    {
        Instantiate(peaBullet, this.gameObject.transform);
        
    }
}
