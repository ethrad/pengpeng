using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;


[System.Serializable]
public class Player
{
    public int money;
    public int talkNum;
    public int dayNum;
    public int deadNum;
}

public class PlayerController : MonoBehaviour
{
    public GameObject playerInfo;
    TextAsset textData;
    Player player = new Player();


    // Start is called before the first frame update
    void Start()
    {
        textData = Resources.Load("DB/Player") as TextAsset;
        player = JsonUtility.FromJson<Player>(textData.ToString());
        playerInfo.transform.GetComponent<Text>().text = "돈 : " + player.money + "   D-" + player.dayNum + "\n남은 대화 횟수" + player.talkNum;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
