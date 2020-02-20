using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestController : MonoBehaviour
{
    public GameObject QuestPanel;

    public void OnQuestButtonClicked()
    {
        Move.touch = false;
        QuestPanel.SetActive(true);
        questPanelUpdate();
        
    }

    void questCheck(int questNum)
    {
        switch (questNum)
        {
            case 0:

                break;
            case 1:
                break;

        }
    }

    public void OnEscapeButtonClicked() {
        QuestPanel.SetActive(false);
        Move.touch = true;
    }

    void questPanelUpdate() {

    }
}
