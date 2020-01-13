using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

[Serializable]
public class Item
{
    public int IID;
    public string name;
    public string description;
    public string image;
}

[Serializable]
public class ItemDB
{
    public List<Item> ItemList;
}

public class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    public static ItemDB IL = new ItemDB();
    public GameObject UI_image;
    public Text UI_name;
    public Text UI_description;
   
    TextAsset textData;

    void Start()
    {
        
    }

}
