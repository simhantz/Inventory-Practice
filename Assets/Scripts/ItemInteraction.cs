using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class ItemInteraction : InteractSystem
{
    public Item thisItem;
    public void PickUpOrDestroy()
    {
        if (inRange)
        {
            ItemInstance thisItemInstance = new ItemInstance(thisItem);
            if (Inventory.Instance.AddItem(thisItemInstance))
            {
                Destroy(gameObject);
            }
        }
    }
    public void Place()
    {
        ItemInstance toPlace = Inventory.Instance.itemsInventory.First();
        toPlace.itemType = Inventory.Instance.itemsInventory.First().itemType;
        toPlace.prefab = Inventory.Instance.itemsInventory.First().prefab;
        toPlace.prefab.transform.position = Player.transform.position;
        Instantiate(toPlace.prefab);
        Inventory.Instance.RemoveItem(toPlace);
    }
    public override void Interact()
    {
        if (Input.GetKeyDown(mainInteractKey))
        {
            UnityEvent.Invoke();
        }
    }
}
