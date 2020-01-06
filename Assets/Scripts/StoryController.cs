using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

[Serializable]
public class Story {
    public string background;
    public string script;
}

public class StoryController : MonoBehaviour
{
    private int SN;
    public static List<Story> StoryList;
    public GameObject background;
    public GameObject script;

    TextAsset textData;
    // Start is called before the first frame update
    void Start()
    {
        SN = 0; //scene number;
        textData = Resources.Load("DB/StoryList") as TextAsset;
        StoryList = JsonUtility.FromJson<List<Story>>(textData.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SN++;
            SceneSetting();
        }
    }

    void SceneSetting() {

    }
}
