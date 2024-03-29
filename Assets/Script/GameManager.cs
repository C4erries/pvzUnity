using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainer;
    public float payment;

    public static GameManager instance;
    
    private void Awake()
    {
        instance = this;
    }
    
    public void PlaceObject()
    {
        if (draggingObject != null && currentContainer != null)
        {
            Instantiate(draggingObject.GetComponent<ObjectDragging>().card.object_Game, currentContainer.transform);
            SunWallet.sunCounter -= payment;
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
        }
    }
}
