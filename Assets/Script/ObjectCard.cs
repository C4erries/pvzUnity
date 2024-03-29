using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject object_Drag;
    public GameObject object_Game;
    public Sprite plantCardSprite;
    public Sprite plantSprite;
    public float cost = 100f;
    public float cooldown = 10f;
    private bool isOnCooldown;
    private Canvas canvas;
    private float sunNow = 0f;
    private GameObject objectDragInstance;
    private GameManager gameManager;
    private void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        GameObject Child = this.gameObject.transform.GetChild(0).gameObject;
        gameManager = GameManager.instance;
        object_Game.GetComponent<Image>().sprite = plantSprite;
        GetComponent<Image>().sprite = plantCardSprite;
        Child.GetComponent<Text>().text = cost.ToString();
    }
    private void FixedUpdate()
    {
        sunNow = SunWallet.sunCounter;
        if(isOnCooldown) 
        {
            GetComponent<Image>().color = new Color(0.2471698f, 0.2471698f, 0.3471698f, 1f); // isNotReadyClr
        }
        else if(sunNow < cost)
        {
            GetComponent<Image>().color = new Color(0.5471698f, 0.5471698f, 0.5471698f, 1f); // isHalfReadyClr
        }
        else
        {
            GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f); // isReadyClr
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(sunNow >= cost && !isOnCooldown)
        {
            objectDragInstance.transform.position = Input.mousePosition;
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(sunNow >= cost && !isOnCooldown)
        {
            objectDragInstance = Instantiate(object_Drag, canvas.transform);
            objectDragInstance.GetComponent<Image>().sprite = plantSprite;  
            objectDragInstance.transform.position = Input.mousePosition;
            objectDragInstance.GetComponent<ObjectDragging>().card = this;
            GameManager.instance.draggingObject = objectDragInstance;
            GameManager.instance.payment = cost;
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (sunNow >= cost && !isOnCooldown)
        {
            gameManager.PlaceObject();
            if(GameManager.instance.currentContainer != null) 
            {
                StartCoroutine(setCooldown());
            }
            GameManager.instance.draggingObject = null;
            Destroy(objectDragInstance);
        }
        
    }
    public IEnumerator setCooldown()
    {
        isOnCooldown = true;
        yield return new WaitForSeconds(cooldown);
        isOnCooldown = false;
    }
}
