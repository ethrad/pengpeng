using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

[Serializable]
public class Script
{
    public string background;
    public string bgm;
    public string script;
    public string leftCha;
    public string rightCha;
}

[Serializable]
public class StoryList
{
    public List<Script> Scripts;
}

[Serializable]
public class StoryDB
{
    public List<StoryList> SL;
}

public class StoryController : MonoBehaviour
{
    public static StoryDB storyList = new StoryDB();
    public GameObject background;
    public GameObject script;
    public GameObject leftCha;
    public GameObject rightCha;
    public GameObject name;
    TextAsset textData;
    private int SN;
    public static int storyNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        textData = Resources.Load("DB/StoryList") as TextAsset;
        storyList = JsonUtility.FromJson<StoryDB>(textData.ToString());
        SN = 0;
        SceneSetting();
    }

    // Update is called once per frame
    void Update()
    {
        if (SN == storyList.SL[storyNum].Scripts.Count-1) { }
        else if (Input.GetMouseButtonDown(0))
        {
            SN++;
            SceneSetting();
        }
    }

    void SceneSetting()
    {
        name.transform.GetComponent<Text>().text = storyList.SL[storyNum].Scripts[SN].script.Split(':')[0];
        background.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/" + storyList.SL[storyNum].Scripts[SN].background);
        script.transform.GetComponent<Text>().text = storyList.SL[storyNum].Scripts[SN].script.Split(':')[1];
        leftCha.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/" + storyList.SL[storyNum].Scripts[SN].leftCha);
        rightCha.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/" + storyList.SL[storyNum].Scripts[SN].rightCha);
    }
}
