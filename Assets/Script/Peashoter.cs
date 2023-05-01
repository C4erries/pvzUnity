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
        enemySeen = true;
        { InvokeRepeating("Shoot", 0, 1.0f); }
    }
    private void Shoot()
    {
        if(enemySeen)
        { 
            Instantiate(peaBullet, this.gameObject.transform); 
        } 
    }
}
