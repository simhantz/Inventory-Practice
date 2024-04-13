using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI[] slotText;
    private GameObject childPanel;

    private string defaultText = "*EMPTY*";

    private int slotAmount;
    // Start is called before the first frame update
    void Start()
    {
        childPanel = gameObject.transform.GetChild(0).gameObject;
        slotText = childPanel.GetComponentsInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            childPanel.SetActive(!childPanel.activeSelf);
        }

        slotAmount = Inventory.Instance.itemsInventory.Count;
        for (int i = 0; i < slotAmount; i++)
        {
            slotText[i].text = Inventory.Instance.itemsInventory[i].name;


            //if (Inventory.Instance.itemsInventory.ElementAtOrDefault(i + 1) == null)
            //{
            //    slotText[i + 1].text = "*EMPTY*";
            //    return;
            //}
        }

        //int j = 0;
        //foreach (var text in slotText)
        //{
        //    if (Inventory.Instance.itemsInventory.ElementAt(j) == null)
        //    {
        //        text.text = defaultText;
        //    }
        //    j++;
        //}

    }
}
