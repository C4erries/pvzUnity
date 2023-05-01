using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject object_Drag;
    public GameObject object_Game;
    public static float cost = 100f;
    public Canvas canvas;
    public Color bColor;
    public Color gColor;
    private float sunNow = 0f;
    private GameObject objectDragInstance;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.instance;
    }
    private void FixedUpdate()
    {
        sunNow = SunWallet.sunCounter;
        if(sunNow < cost)
        {
            GetComponent<Image>().color = bColor;
        }
        else
        {
            GetComponent<Image>().color = gColor;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(sunNow >= cost)
        {
            objectDragInstance.transform.position = Input.mousePosition;
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(sunNow >= cost)
        {
            objectDragInstance = Instantiate(object_Drag, canvas.transform);
            objectDragInstance.transform.position = Input.mousePosition;
            objectDragInstance.GetComponent<ObjectDragging>().card = this;
            GameManager.instance.draggingObject = objectDragInstance;
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if(sunNow >= cost)
        {
            gameManager.PlaceObject();
            GameManager.instance.draggingObject = null;
            Destroy(objectDragInstance);
        }
        
    }
}
