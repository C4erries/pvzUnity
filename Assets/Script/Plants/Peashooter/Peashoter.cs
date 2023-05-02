using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peashoter : MonoBehaviour
{
    public GameObject peaBullet;
    public bool enemySeen = true;
    void Start()
    {
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
