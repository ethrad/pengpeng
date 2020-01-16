using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    public GameObject QuestPanel;

    public void OnQuestButtonClicked()
    {
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

    void questPanelUpdate() {

    }
}
