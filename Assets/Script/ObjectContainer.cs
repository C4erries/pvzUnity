using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectContainer : MonoBehaviour
{
    public bool isFull;
    public GameManager gameManager;
    public Image backgroundImage;
    public void Start()
    {
        gameManager = GameManager.instance;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameManager.draggingObject.tag=="dragplant" && !isFull)
        {
            gameManager.currentContainer = this.gameObject;
            backgroundImage.enabled = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        backgroundImage.enabled = false;
        gameManager.currentContainer = null;

    }
}
