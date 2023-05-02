using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Peashoter : mainplant
{
    public GameObject peaBullet;
    public bool enemySeen = true;
    private Canvas canvas;
    private Transform trans;
    void Start()
    {
        canvas = this.GetComponentInParent<Canvas>();

        { InvokeRepeating("Shoot", 0, 1.0f); }
    }

    private void Update()
    {
        if (hp <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
    private void Shoot()
    {
        if(enemySeen)
        {
            trans = this.gameObject.transform;
            Instantiate(peaBullet, new Vector3(trans.position.x, trans.position.y, trans.position.z), Quaternion.identity,  canvas.transform); 
        } 
    }
}
