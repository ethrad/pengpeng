using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class Character
{
    public int CID;
    public string name;
    public int BID;
    public int QID;
    public int like;
    public string script;
    public string image;
}

[System.Serializable]
public class CharacterList
{
    public List<Character> CL;
}

public class CharacterContoller : MonoBehaviour
{
    public GameObject script;
    public CharacterList chaList = new CharacterList();

    TextAsset textData;

    // Start is called before the first frame update
    void Start()
    {
        textData = Resources.Load("DB/CharacterList") as TextAsset;
        chaList = JsonUtility.FromJson<CharacterList>(textData.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCharacterClicked() {
        script.transform.GetComponent<Text>().text = chaList.CL[int.Parse(EventSystem.current.currentSelectedGameObject.name)].script;
    }
}
