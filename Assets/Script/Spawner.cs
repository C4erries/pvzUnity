using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Android;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float lastspawned;
    public float spawnTime;
    public GameObject zomb;
    public Canvas canvas;
    private int ypos;
    
    void Start()
    {
        lastspawned = Time.time;
        ypos = Random.Range(0, 5);
    }


    void Update()
    {
        switch (ypos) 
        { 
            case 0:
                ypos = -134;
                break;
            case 1:
                ypos = -76;
                break;
            case 2:
                ypos = -18;
                break;
            case 3:
                ypos = 40;
                break;
            case 4:
                ypos = 98;
                break;
            default: break;
        }
        if ((Time.time - lastspawned)>=spawnTime) {
            Instantiate(zomb, new Vector3(790, ypos+262, 0), Quaternion.identity, canvas.transform);
            lastspawned = Time.time;
            ypos = Random.Range(0, 5);
        }
    }
}
