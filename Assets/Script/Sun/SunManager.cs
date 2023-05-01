using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunManager : MonoBehaviour
{
    public static SunManager instance;
    public GameObject sunPoint;
    public float spawnSunInterval = 2.0f;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
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
