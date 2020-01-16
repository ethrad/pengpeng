using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveArea()
    {
        SceneManager.LoadScene("Area" + AreaName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
