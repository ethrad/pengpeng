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
    public GameObject InventoryPanel;
    int length;

    // Start is called before the first frame update
    void Start()
    {/*

        GameObject temp=(GameObject)Instantiate(slot, transform); //as GameObject
        ItemController a = temp.GetComponent<ItemController>();
        a.UI_name.transform.GetComponent<Text>().text = "와";
        a.UI_image.transform.GetComponent <Image>().sprite= Resources.Load<Sprite>("Images/qoqto");
        Debug.Log("NOOOOOOOOOOOO");
        */

        //temp = Instantiate<GameObject>(slot, i.GetComponent<Transform>());

        //GameObject sub1 = temp.Find("image").GetComponentsInChildren<Image>();
        //sub1.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/qoqto");

        /*
        GameObject sub1 = temp.transform.Find("image").gameObject;
        GameObject sub2 = temp.transform.Find("name").gameObject;
        GameObject sub3 = temp.transform.Find("description").gameObject;

        Image sub1=temp.transform.GetComponent<Image>;
        sub1.UI_image=Resources.Load<Sprite>("Images/qoqto");
        Text sub2.GetComponent<Text>().text;
        sub2.UI_name="뱁새";
        Text sub3.GetComponent<Text>().text;
        sub3.UI_description="맛있는꽃";
        */


        //for (int i = 0; i < 10; i++) {
        //GameObject temp = Instantiate(slot, transform) //as GameObject;
        //temp.GetComponentInChildren < UI_image >= "qoqto";
        //temp.transform.GetChild.GetComponent<i().spriteName = "qoqto";
        //}

        textData = Resources.Load("DB/ItemList") as TextAsset;
        IL = JsonUtility.FromJson<ItemDB>(textData.ToString());
        length = IL.ItemList.Count;
        for (int n = 0; n < length; n++)
        {
            Instantiate(slot, i.GetComponent<Transform>());
            Debug.Log("sa");
        }

        
        
    }



    public void SlotUpdate()
    {
        for (int n = 0; n < length; n++)
        {
            i.transform.GetChild(n).transform.GetChild(2).GetComponent<Text>().text = IL.ItemList[n].name;
            Debug.Log(i.transform.GetChild(n).transform.GetChild(2).GetComponent<Text>().text);
            i.transform.GetChild(n).transform.GetChild(3).GetComponent<Text>().text = IL.ItemList[n].description;
            i.transform.GetChild(n).transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/" + IL.ItemList[n].image);
        }
        InventoryPanel.SetActive(true);
    }
}
