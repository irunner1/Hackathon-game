using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public Sprite opened;
    private SpriteRenderer spriteRenderer;
    public bool isOpened = false;
    public bool isEmpty = false;
    public bool isInTrigger = false;
    public bool canOpen = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isInTrigger)
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (canOpen)
                {
                    changeSprite();
                    isOpened = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInTrigger = true;
        if (!isOpened)
        {
            if (other.gameObject.TryGetComponent<Player_Key>(out Player_Key comp))
            {
                if (comp.isKey)
                {
                    canOpen = true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(isOpened)
        {
            if (other.gameObject.TryGetComponent<Player_Key>(out Player_Key comp))
            {
                comp.isKey = false;
            }
        }
        isInTrigger = false;
    }
    private void changeSprite()
    {
        if (isOpened)
        {
            spriteRenderer.sprite = opened;
        }
    }
}
