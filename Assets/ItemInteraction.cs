using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public Item thisItem;

    void Start()
    {
        thisItem.spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
    }
    public void PickUpOrDestroy()
    {
        // Tar bort objektet för nu
        Destroy(gameObject);
    }
}
