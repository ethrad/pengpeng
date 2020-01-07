using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BuildingController : MonoBehaviour
{
    public void OnBuildingClicked() {
        SceneManager.LoadScene(EventSystem.current.currentSelectedGameObject.name);
    }
}
