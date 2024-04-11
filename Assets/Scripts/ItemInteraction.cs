using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEngine;
using System.Linq;

public class ItemInteraction : MonoBehaviour
{
    public Item thisItem;
    public Inventory inventory;

    public void PickUpOrDestroy()
    {
        // Tar bort objektet för nu
        inventory.AddItem(thisItem);
        Destroy(gameObject);
    }
    public void Place()
    {
        ItemInstance toPlace = inventory.itemsInventory.First();
        inventory.itemsInventory.Remove(toPlace);
        // Sätter bara ut en kopia och inte "samma"
        Instantiate(toPlace.prefab);
        toPlace.prefab.transform.position = Vector3.zero;
            //new Vector3(player.transform.position.x, player.transform.position.y + 3);
    }
}
