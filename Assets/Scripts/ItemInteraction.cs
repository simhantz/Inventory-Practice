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
            if (PlayerInventory.Instance.AddItem(thisItemInstance))
            {
                Destroy(gameObject);
            }
        }
    }
    public void Place()
    {
        if (PlayerInventory.Instance.itemsInventory.Count > 0)
        {
            ItemInstance toPlace = PlayerInventory.Instance.itemsInventory.First();
            toPlace.itemType = PlayerInventory.Instance.itemsInventory.First().itemType;
            toPlace.prefab = PlayerInventory.Instance.itemsInventory.First().prefab;
            toPlace.prefab.transform.position = Player.transform.position;
            Instantiate(toPlace.prefab);
            PlayerInventory.Instance.RemoveItem(toPlace);
        }
        else Debug.Log("Nothing to place");
    }
    public override void Interact()
    {
        if (Input.GetKeyDown(mainInteractKey))
        {
            UnityEvent.Invoke();
        }
    }
}
