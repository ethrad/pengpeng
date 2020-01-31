using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject MapPanel;

    public void OnMapButtonClicked()
    {
        Move.touch = false;
        MapPanel.SetActive(true);
    }

    public void OnEscapeButtonClicked()
    {
        MapPanel.SetActive(false);
        Move.touch = true;
    }
}
