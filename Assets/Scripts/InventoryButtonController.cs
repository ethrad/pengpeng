using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButtonController : MonoBehaviour
{
    public GameObject item;
    public GameObject InventoryPanel;
    

    public void OnInventoryButtonClicked()
    {
        InventoryPanel.SetActive(true);
        inventoryPanelUpdate();
        //item.make_clone.SlotUpdate();
    }

    void inventoryPanelUpdate()
    {

    }
}
