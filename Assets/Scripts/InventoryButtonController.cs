using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButtonController : MonoBehaviour
{
    public GameObject canvas;
    public GameObject item;
    public GameObject InventoryPanel;

    public void OnInventoryButtonClicked()
    {
        canvas.GetComponent<make_clone>().SlotUpdate();
        Move.touch = false;
        InventoryPanel.SetActive(true);
    }

    public void OnEscapeButtonClicked()
    {
        for (int n = 0; n < make_clone.length; n++) {
            Destroy(item.transform.GetChild(n).gameObject);
        }
        InventoryPanel.SetActive(false);
        Debug.Log("dkdkdk");
        Move.touch = true;
    }
}
