using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : InteractSystem
{
    public ChestInventory chestSpace;
    public Item aItem;

    [HideInInspector] public bool isOpen = false;

    void Start()
    {
        chestSpace = gameObject.AddComponent<ChestInventory>();
        chestSpace.AddItem(new ItemInstance(aItem));
    }

    public void OpenChest()
    {
        if (!inRange)
        {
            return;
        }

        if (!isOpen)
        {
            // Open
            isOpen = !isOpen;
        }
        else
        {
            // Close
            isOpen = !isOpen;
        }
    }
}
