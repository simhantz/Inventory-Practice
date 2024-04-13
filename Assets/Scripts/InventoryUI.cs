using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI[] slotText;
    private GameObject childPanel;
    private GameObject childTitleBlock;


    private string defaultText = "*EMPTY*";

    private int slotAmount;
    // Start is called before the first frame update
    void Start()
    {
        childPanel = gameObject.transform.GetChild(0).gameObject;
        childTitleBlock = gameObject.transform.GetChild(1).gameObject;

        slotText = childPanel.GetComponentsInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            childTitleBlock.SetActive(!childPanel.activeSelf);
            childPanel.SetActive(!childPanel.activeSelf);
        }

        for (int i = 0; i < slotText.Length; i++)
        {
            slotText[i].text = defaultText;
        }

        slotAmount = PlayerInventory.Instance.itemsInventory.Count;
        for (int i = 0; i < slotAmount; i++)
        {
            slotText[i].text = PlayerInventory.Instance.itemsInventory[i].name;
        }
    }
}
