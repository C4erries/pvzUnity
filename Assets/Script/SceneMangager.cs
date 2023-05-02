using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMangager : MonoBehaviour
{
    public GameObject objectCard;
    public GameObject CardPeashooter;
    public GameObject CardSunflower;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        GameObject card1 = Instantiate(CardPeashooter, canvas.transform);
        card1.tag = "plant";
        card1.transform.position = new Vector3(100, 400, 0);
        GameObject card2 = Instantiate(CardSunflower, canvas.transform);
        card2.transform.position = new Vector3(100, 300, 0);
        card2.tag = "plant";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
