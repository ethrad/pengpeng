﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject MapPanel;

    public void OnMapButtonClicked() {
        MapPanel.SetActive(true);
    }
}