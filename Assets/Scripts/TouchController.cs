using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{
    private const float SwipeDis = 10;//스와이프 허용 범위 수정하고 싶으면 이거 수정하셈
    private Vector2 StartPos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 p = (Vector2)Input.mousePosition - StartPos;

            if (Mathf.Abs(p.x) < SwipeDis && Mathf.Abs(p.y) < SwipeDis)
                GetClick();
            else
            {
                if (Mathf.Abs(p.x) > Mathf.Abs(p.y))
                    GetSwipe(StartPos, new Vector2(Mathf.Sign(p.x), 0));
                else if (Mathf.Abs(p.x) < Mathf.Abs(p.y))
                    GetSwipe(StartPos, new Vector2(0, Mathf.Sign(p.y)));
            }
        }
    }

    public virtual void GetClick() {
        Debug.Log("클릭");
    }
    public virtual void GetSwipe(Vector2 StartPos, Vector2 dir) {
        Debug.Log("스와이프");
    }

}