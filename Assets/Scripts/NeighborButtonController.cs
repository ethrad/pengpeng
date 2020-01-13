using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighborButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NeighborPanel;
    public GameObject canvas;
    public GameObject neighbor;
    public void OnNeighborButtonClicked()
    {
        canvas.GetComponent<make_clone1>().SlotUpdate();
        NeighborPanel.SetActive(true);

    }

    public void OnEscapeButtonClicked()
    {
        for (int n = 0; n < make_clone1.length; n++)
        {
            Destroy(neighbor.transform.GetChild(n).gameObject);
        }
        NeighborPanel.SetActive(false);
    }
}
