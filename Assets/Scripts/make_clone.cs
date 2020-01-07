using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class make_clone : MonoBehaviour
{
    
    public GameObject slot;
    // Start is called before the first frame update
    void Start()
    {/*
        GameObject temp=(GameObject)Instantiate(slot, transform); //as GameObject
        ItemController a = temp.GetComponent<ItemController>();
        a.UI_name.transform.GetComponent<Text>().text = "와";
        a.UI_image.transform.GetComponent <Image>().sprite= Resources.Load<Sprite>("Images/qoqto");
        Debug.Log("NOOOOOOOOOOOO");
        */

        GameObject temp = (GameObject)Instantiate(slot, transform) as GameObject;

        temp.transform.Find("name").GetComponent<Text>().text = "te";
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

    // Update is called once per frame
    void Update()
    {
        //GameObject instance = Instantiate(slot, transform.position, transform.rotation,transform) as GameObject;
    }
}
