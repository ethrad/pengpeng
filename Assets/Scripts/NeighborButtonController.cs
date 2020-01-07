using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighborButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NeighborPanel;

    public void OnNeighborButtonClicked()
    {
        NeighborPanel.SetActive(true);
        neighborPanelUpdate();
    }

    // Update is called once per frame
    void neighborPanelUpdate()
    {
        
    }
}
