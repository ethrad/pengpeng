using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestController : MonoBehaviour
{
    public GameObject QuestPanel;

    public void OnQuestButtonClicked()
    {
        QuestPanel.SetActive(true);
        questPanelUpdate();
        Move.touch = false;
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

    void questPanelUpdate() {

    }
}
