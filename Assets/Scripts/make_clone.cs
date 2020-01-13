using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class make_clone : MonoBehaviour
{
    GameObject temp;
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
    }

    public static ItemDB IL = new ItemDB();
    static TextAsset textData;


    // Update is called once per frame
    public void SlotUpdate()
    {
        //temp.transform.GetChild(2).GetComponent<Text>().text = "aa";

        textData = Resources.Load("DB/ItemList") as TextAsset;
        IL = JsonUtility.FromJson<ItemDB>(textData.ToString());
        int length = IL.ItemList.Count;
        string t;
        Debug.Log(length);
        for (int n = 1; n < length; n++)
        {
            temp = (GameObject)Instantiate(slot, i.GetComponent<Transform>());
            temp.transform.GetChild(2).GetComponent<Text>().text = IL.ItemList[n].name;
            Debug.Log("temp 이름 : " + temp.transform.GetChild(2));
            temp.transform.GetChild(3).GetComponent<Text>().text = IL.ItemList[n].description;
            temp.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/" + IL.ItemList[n].image);
        }

    }
}
