using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestButtonController : MonoBehaviour
{
    public GameObject QuestPanel;

    public void OnQuestButtonClicked()
    {
        QuestPanel.SetActive(true);
        questPanelUpdate();
        Move.touch = false;
    }

    void questPanelUpdate() {

    }
}
