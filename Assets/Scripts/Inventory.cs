using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        if (testItem != null)
        {
            ItemInstance test = new ItemInstance(testItem);
            itemsInventory.Add(test);
        }
    }
}

[System.Serializable]
public class ItemInstance
{
    public Item itemType;
    public int itemDurability;

    public GameObject prefab;

    private string name;
    private string description;


    public ItemInstance(Item item)
    {
        itemType = item;
        name = item.name;
        description = item.description;
        prefab = item.prefab;
        itemDurability = item.defaultDurability;
    }
}