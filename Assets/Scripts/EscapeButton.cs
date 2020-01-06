using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeButton : MonoBehaviour
{
    public GameObject SlotPanel;

    public void EscapeButtonClicked()
    {
        SlotPanel.SetActive(false);
    }
}
