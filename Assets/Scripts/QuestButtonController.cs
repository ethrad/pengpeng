using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestButtonController : MonoBehaviour
{
    public GameObject QuestPanel;

    public void OnQuestButtonClicked()
    {
        QuestPanel.SetActive(true);
        questPanelUpdate();
    }

    void questPanelUpdate() {

    }
}
