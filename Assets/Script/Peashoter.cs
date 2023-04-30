using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peashoter : MonoBehaviour
{
    public GameObject peaBullet;
    public Canvas canvas;
    public bool enemySeen = false;
    void Start()
    {
        canvas = this.GetComponentInParent<Canvas>();
        { InvokeRepeating("Shoot", 0, 2.0f); }
        enemySeen = false;
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
