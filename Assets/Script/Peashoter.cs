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
<<<<<<< HEAD
        { InvokeRepeating("Shoot", 0, 2.0f); }
        enemySeen = true;
=======
        { InvokeRepeating("Shoot", 0, 1.0f); }
>>>>>>> 86e658494f7664159ef6cdbcf7bcfd34dd894fb7
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
