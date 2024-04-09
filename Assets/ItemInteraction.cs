using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public Item thisItem;
    public Inventory inventory;

    void Start()
    {
        thisItem.spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        thisItem.obj = gameObject;
    }
    public void PickUpOrDestroy()
    {
        inventory.AddItem(thisItem);
        // Tar bort objektet för nu
        Destroy(gameObject);
    }
    public void Place()
    {
        thisItem.obj.transform.position = Vector3.zero;
        Instantiate(thisItem.obj);
    }
}
