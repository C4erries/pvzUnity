using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunWallet : MonoBehaviour
{
    public static float sunCounter;
    private Text suns;
    void Start()
    {
        suns = GetComponent<Text>();
        sunCounter = 0;
    }
    void Update()
    {
        
        suns.text = "Suns: " + sunCounter.ToString();
    }
}
