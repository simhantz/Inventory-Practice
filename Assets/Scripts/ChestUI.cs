using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChestUI : MonoBehaviour
{
    public ChestInteraction chestScript;

    private GameObject childObject;
    private GameObject childTitleBlock;
    private TextMeshProUGUI[] ui = null;
    private string defaultText = "*EMPTY-CHEST*";
    // Start is called before the first frame update
    void Start()
    {
        childObject = gameObject.transform.GetChild(0).gameObject;
        childTitleBlock = gameObject.transform.GetChild(1).gameObject;
        ui = childObject.GetComponentsInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        childObject.SetActive(chestScript.isOpen);
        childTitleBlock.SetActive(chestScript.isOpen);

        if (!chestScript.inRange) 
        {
            chestScript.isOpen = false;
            childObject.SetActive(false);
            childTitleBlock.SetActive(false);
        }

        for (int i = 0; i < ui.Length; i++)
        {
            ui[i].text = defaultText;
        }

        int slotAmount = chestScript.chestSpace.itemsInventory.Count;
        for (int i = 0; i < slotAmount; i++)
        {
            ui[i].text = chestScript.chestSpace.itemsInventory[i].name;
        }

    }
}
