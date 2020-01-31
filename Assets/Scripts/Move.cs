using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public static bool touch = true;
    public static int AreaNum=0;

    [Serializable]
    public class Area
    {
        public int AID;
        public int[] canMove;
        //public string bgm;
    }

    [Serializable]
    public class AreaDB
    {
        public List<Area> AreaList;
    }

    public static AreaDB AL = new AreaDB();
    static TextAsset textData;

    void Awake()
    {
        Screen.SetResolution(828, 1792, false);
    }
    // Start is called before the first frame update
    void Start()
    {
        textData = Resources.Load("DB/AreaList") as TextAsset;
        AL = JsonUtility.FromJson<AreaDB>(textData.ToString());
        //length = AL.AreaList.Count;
    }



    public virtual void Update()
    {

        if (touch == true)
        {
            if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Right))
            {
                if (AL.AreaList[AreaNum].canMove[0] != -1)
                {
                    AreaNum = AL.AreaList[AreaNum].canMove[0];
                    SceneManager.LoadScene("Area" + AreaNum);
                }
                Debug.Log(AreaNum);

            }

            if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Down))
            {
                if (AL.AreaList[AreaNum].canMove[1] != -1)
                {
                    AreaNum = AL.AreaList[AreaNum].canMove[1];
                    SceneManager.LoadScene("Area" + AreaNum);
                }
                Debug.Log(AreaNum);
            }

            if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Left))
            {
                if (AL.AreaList[AreaNum].canMove[2] != -1)
                {
                    AreaNum = AL.AreaList[AreaNum].canMove[2];
                    SceneManager.LoadScene("Area" + AreaNum);
                }
                Debug.Log(AreaNum);

            }

            if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Up))
            {

                if (AL.AreaList[AreaNum].canMove[3] != -1)
                {
                    AreaNum = AL.AreaList[AreaNum].canMove[3];
                    SceneManager.LoadScene("Area" + AreaNum);
                }
                Debug.Log(AreaNum);
            }

            ExampleCoroutine();
        }
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.5f);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

}
