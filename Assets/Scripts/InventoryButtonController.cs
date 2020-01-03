using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButtonController : MonoBehaviour
{
    public GameObject InventoryPanel;

    public void OnInventoryButtonClicked()
    {
        InventoryPanel.SetActive(true);
        inventoryPanelUpdate();
    }

    void inventoryPanelUpdate()
    {

    }
}
