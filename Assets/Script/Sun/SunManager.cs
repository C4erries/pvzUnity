using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunManager : MonoBehaviour
{
    public static SunManager instance;
    public GameObject sunPoint;
    public float spawnSunInterval;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        spawnSunInterval = 5.0f;
        { InvokeRepeating("Deployer", 0, spawnSunInterval); }
    }
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void Deployer()
    {
        Instantiate(sunPoint, canvas.transform);
    }

}
