using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeButton : MonoBehaviour
{
    public GameObject[] Panels;

    void Update() {
        //if (Application.platform == RuntimePlatform.Android)
        //{
            if (Input.GetKey(KeyCode.Escape)){
                foreach (GameObject p in Panels) {
                    p.SetActive(false);
                    Move.touch = true;
                }
            }

        //}
    }
}
