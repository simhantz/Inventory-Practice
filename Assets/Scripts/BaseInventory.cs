using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInventory : MonoBehaviour
{
    public int inventorySpaces = 4;
    public List<ItemInstance> itemsInventory = new();


    public Item testItem;

    public bool AddItem(ItemInstance item)
    {
        if (itemsInventory.Count < inventorySpaces)
        {
            itemsInventory.Add(item);
            return true;
        }
        Debug.Log("Not enough inventory spaces");
        return false;
    }
    public void RemoveItem(ItemInstance item)
    {
        itemsInventory.Remove(item);
    }
    // Temporary method
    public void ClearInventory()
    {
        itemsInventory.Clear();
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

    public SpriteRenderer spriteRenderer;
    public string name { get; private set; }
    private string description;


    public ItemInstance(Item item)
    {
        itemType = item;
        name = item.name;
        description = item.description;
        prefab = item.prefab;
        itemDurability = item.defaultDurability;
        spriteRenderer = item.spriteRenderer;
    }
}
