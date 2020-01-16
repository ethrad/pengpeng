using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeReceiver : MonoBehaviour
{
    //override this
    protected virtual void OnSwipeLeft()
    {

    }

    //override this
    protected virtual void OnSwipeRight()
    {

    }

    //override this
    protected virtual void OnSwipeUp()
    {

    }

    //override this
    protected virtual void OnSwipeDonw()
    {

    }

    protected virtual void Update()
    {
        if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Right))
        {

            OnSwipeRight();
            Debug.Log("오른쪽");
        }

        if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Left))
        {
            OnSwipeLeft();
            Debug.Log("왼쪽");
        }

        if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Up))
        {
            OnSwipeUp();
            Debug.Log("위쪽");
        }

        if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Down))
        {
            OnSwipeDonw();
            Debug.Log("아래쪽");
        }
    }


}
