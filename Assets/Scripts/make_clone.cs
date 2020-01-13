using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class make_clone : MonoBehaviour
{
    public GameObject i;
    public GameObject slot;

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

    public static ItemDB IL = new ItemDB();
    static TextAsset textData;
    public static int length;

    // Start is called before the first frame update
    void Start()
    {
        textData = Resources.Load("DB/ItemList") as TextAsset;
        IL = JsonUtility.FromJson<ItemDB>(textData.ToString());
        length = IL.ItemList.Count;
    }

    public void SlotUpdate()
    {
        for (int n = 0; n < length; n++)
        {
            Instantiate(slot, i.GetComponent<Transform>());
        }

        for (int n = 0; n < length; n++)
        {
            i.transform.GetChild(n).transform.GetChild(2).GetComponent<Text>().text = IL.ItemList[n].name;
            i.transform.GetChild(n).transform.GetChild(3).GetComponent<Text>().text = IL.ItemList[n].description;
            i.transform.GetChild(n).transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/" + IL.ItemList[n].image);
        }
        
    }
}
