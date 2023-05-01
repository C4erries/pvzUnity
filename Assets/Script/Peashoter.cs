using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peashoter : MonoBehaviour
{
    public GameObject peaBullet;
    public Canvas canvas;
    public bool enemySeen = true;
    void Start()
    {
        canvas = this.GetComponentInParent<Canvas>();
        { InvokeRepeating("Shoot", 0, 1.0f); }
    }

    // Update is called once per frame
    private void Shoot()
    {
        if(enemySeen)
        { 
            Instantiate(peaBullet, this.gameObject.transform); 
        } 
    }
}
