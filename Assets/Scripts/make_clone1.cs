using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class make_clone1 : MonoBehaviour
{
    [Serializable]
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

    [Serializable]
    public class CharacterList
    {
        public List<Character> CL;
    }

    public GameObject bird;
    public GameObject neighbor;

    public GameObject script;
    public CharacterList chaList = new CharacterList();
    public static int length;
    TextAsset textData;

    // Start is called before the first frame update
    void Start()
    {
        textData = Resources.Load("DB/CharacterList") as TextAsset;
        chaList = JsonUtility.FromJson<CharacterList>(textData.ToString());
        length = chaList.CL.Count;
    }

    public void SlotUpdate()
    {
        for (int n = 0; n < length; n++)
        {
            Instantiate(bird, neighbor.GetComponent<Transform>());
        }

        for (int n = 0; n < length; n++)
        {
            neighbor.transform.GetChild(n).transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/" + chaList.CL[n].image);
            neighbor.transform.GetChild(n).transform.GetChild(1).GetComponent<Text>().text = chaList.CL[n].name;
            neighbor.transform.GetChild(n).transform.GetChild(2).GetComponent<Text>().text = "호감도: "+chaList.CL[n].like.ToString();
        }

    }

    public void OnCharacterClicked()
    {
        //script.transform.GetComponent<Text>().text = chaList.CL[int.Parse(EventSystem.current.currentSelectedGameObject.name)].script;
    }
}

