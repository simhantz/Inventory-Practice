using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemInstance> itemsInventory = new();

    public Item testItem;

    public void AddItem(Item item)
    {
        itemsInventory.Add(new ItemInstance(item));
    }
    public void RemoveItem(Item item)
    {
        itemsInventory.Remove(new ItemInstance(item));
    }
    
    void Start()
    {
        ItemInstance test = new ItemInstance(testItem);
        itemsInventory.Add(test);
    }
}

[System.Serializable]
public class ItemInstance
{
    public Item itemType;
    public int itemDurability;

    public ItemInstance(Item item)
    {
        itemDurability = item.defaultDurability;
        itemType = item;
    }
}