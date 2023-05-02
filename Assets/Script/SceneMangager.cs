using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMangager : MonoBehaviour
{
    public GameObject objectCard;
    public GameObject CardPeashooter;
    public GameObject CardSunflower;
    public GameObject CardWallNut;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        GameObject card1 = Instantiate(CardPeashooter, canvas.transform);
        card1.transform.position = new Vector3(100, 480, 0);
        GameObject card2 = Instantiate(CardSunflower, canvas.transform);
        card2.transform.position = new Vector3(170, 480, 0);
        GameObject card3 = Instantiate(CardWallNut, canvas.transform);
        card3.transform.position = new Vector3(240, 480, 0);
        card1.tag = "Plant";
        card2.tag = "Plant";
        card3.tag = "Plant";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
