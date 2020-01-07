using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

[Serializable]
public class Story
{
    public string background;
    public string bgm;
    public string script;
}

[Serializable]
public class StoryList {
    public List<Story> SL;
}

public class StoryController : MonoBehaviour
{
    public static StoryList storyList = new StoryList();
    public GameObject background;
    public GameObject script;
    TextAsset textData;

    // Start is called before the first frame update
    void Start()
    {
        textData = Resources.Load("DB/StoryList") as TextAsset;
        storyList = JsonUtility.FromJson<StoryList>(textData.ToString());
        Debug.Log(storyList.SL[0].background);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
