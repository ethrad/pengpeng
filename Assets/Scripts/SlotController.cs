using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    public GameObject SlotPanel;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SlotPanel.SetActive(false);
        }
    }


    public void OnSlotButtonClicked()
    {
        int i = this.transform.GetSiblingIndex();
        if (DataController.BirdList.BirdInfo[i].IsGot == true)
        {
            SlotPanel.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>(DataController.BirdList.BirdInfo[i].Image);
            SlotPanel.transform.GetChild(1).GetComponent<Text>().text = DataController.BirdList.BirdInfo[i].Name;
            //SlotPanel.transform.GetChild(2).GetComponent<Text>().text = DataController.BirdList.BirdInfo[i].Love;
            SlotPanel.transform.GetChild(3).GetComponent<Text>().text = DataController.BirdList.BirdInfo[i].Detail;
            SlotPanel.SetActive(true);
        }
    }
}
