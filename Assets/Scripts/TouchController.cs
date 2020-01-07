using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{
    Vector2[] firstFingerPosition; // first finger position
    Vector2[] lastFingerPosition; // last finger position
    float angle;
    float swipeDistanceX;
    float swipeDistanceY;
    float SWIPE_DISTANCE_X_CONST = 60;
    float SWIPE_DISTANCE_Y_CONST = 150;
    int touchFingerId = -1;
    int touchCount;
    void Update()
    {
        touchCount = Input.touchCount;
        for (int i = 0; i < touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            if (touch.Equals(null)) continue;

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Touch Began : " + i);
                    touchFingerId = touch.fingerId;
                    firstFingerPosition[i] = touch.position;
                    lastFingerPosition[i] = touch.position;
                    break;
                case TouchPhase.Moved:
                    if (touch.fingerId == touchFingerId)
                    {
                        lastFingerPosition[i] = touch.position;
                        swipeDistanceX = Mathf.Abs((lastFingerPosition[i].x - firstFingerPosition[i].x));
                        swipeDistanceY = Mathf.Abs((lastFingerPosition[i].y - firstFingerPosition[i].y));
                    }
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    Debug.Log("Touch End : " + i);
                    if (touch.fingerId == touchFingerId)
                    {
                        touchFingerId = -1;
                        angle = Mathf.Atan2((lastFingerPosition[i].x - firstFingerPosition[i].x), (lastFingerPosition[i].y - firstFingerPosition[i].y)) * 57.2957795f;

                        if (angle > -30 && angle < 30 && swipeDistanceY > SWIPE_DISTANCE_Y_CONST)
                        {
                            Debug.Log("up  swipe...");
                        }
                        else if (angle > 150 || angle < -150 && swipeDistanceY > SWIPE_DISTANCE_Y_CONST)
                        {
                            Debug.Log("down  swipe...");
                        }
                        else if (angle <= -50 && angle >= -110 && swipeDistanceX > SWIPE_DISTANCE_X_CONST)
                        {
                            Debug.Log("left swipe...");
                        }
                        else if (angle >= 50 && angle <= 110 && swipeDistanceX > SWIPE_DISTANCE_X_CONST)
                        {
                            Debug.Log("right swipe...");
                        }
                    }
                    break;
            }
        }
    }

}