using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButtonController : MonoBehaviour
{
    public GameObject canvas;

    public void OnInventoryButtonClicked()
    {
        canvas.GetComponent<make_clone>().SlotUpdate();
    }
}
