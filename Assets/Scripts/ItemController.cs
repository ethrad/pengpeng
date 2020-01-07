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
        

        textData = Resources.Load("DB/ItemList") as TextAsset;
        IL = JsonUtility.FromJson<ItemDB>(textData.ToString());
        int length = IL.ItemList.Count;
        Debug.Log(length);
        for (int n = 0; n < length; n++)
        {
            UI_name.GetComponent<Text>().text = IL.ItemList[n].name;
            UI_description.GetComponent<Text>().text = IL.ItemList[n].description;
            UI_image.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/" + IL.ItemList[n].image);
        }
        Debug.Log(IL.ItemList[0].name);
        Debug.Log("sss");
    }

}
