using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Item itemType;
    public List<ItemInstance> itemsInventory= new();

    // Start is called before the first frame update
    void Start()
    {
        itemsInventory.Add(new ItemInstance(itemType));
        
    }
}
public class ItemInstance
{
    public Item itemType;

    public ItemInstance(Item item)
    {
        item.durability = itemType.defaultDurability;
    }
}