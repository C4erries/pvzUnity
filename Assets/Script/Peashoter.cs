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
<<<<<<< HEAD
        enemySeen = true;
        { InvokeRepeating("Shoot", 0, 1.0f); }
=======
        { InvokeRepeating("Shoot", 0, 2.0f); }
        enemySeen = false;
>>>>>>> parent of 86e6584 (Added Zombie)
    }
    private void Shoot()
    {
        if(enemySeen)
        { 
            Instantiate(peaBullet, this.gameObject.transform); 
        } 
    }
}
