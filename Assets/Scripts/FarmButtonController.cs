using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

[Serializable]
public class Item
{
    public int IID;
    public string category = string.Empty;
    public string name = string.Empty;
    public string description = string.Empty;
    public string image = string.Empty;

    public Item(int _IID, string _category, string _name, string _description, string _image)
    {
        this.IID = _IID;
        this.category = _category;
        this.name = _name;
        this.description = _description;
        this.image = _image;
    }
}

public class FarmButtonController : MonoBehaviour
{
    public const string myDBAddress = "https://saegame-b26d3.firebaseio.com/";
    public const string jsonExtention = "*.json";

    bool empty;
    public GameObject InventoryPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PostToDatabase()
    {
        RestClient.Put(myDBAddress + inputFieldName.text + jsonExtention, this.user);
    }

    private void ReceiveFromDatabase()
    {
        RestClient.Get<User>(myDBAddress + inputFieldName.text + jsonExtention).Then(response =>
        {
            this.user = response;
        });
    }


    public void OnFarmClicked() {
        if (empty == true)
        {
            //카테고리가 씨앗인 것만 뽑아 인벤토리 출력
            InventoryPanel.SetActive(true);

        }
        else {

        }
    }

    public void OnSeedClicked() {

    }
}
