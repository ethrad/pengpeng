using BackEnd;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackEndInitialize : MonoBehaviour
{
    void Start() {
        // [.net4][il2cpp] 사용 시 필수 사용
        Backend.Initialize(() =>
        {
            // 초기화 성공한 경우 실행
            if (Backend.IsInitialized)
            {
                Debug.Log("뒤끝SDK 초기화 완료");

                // example 
                // 버전체크 -> 업데이트 

                // 구글 해시키 획득 
                if (!Backend.Utils.GetGoogleHash().Equals(""))
                    Debug.Log(Backend.Utils.GetGoogleHash());

                // 서버시간 획득
                Debug.Log(Backend.Utils.GetServerTime());
            }
            // 초기화 실패한 경우 실행
            else
            {
                Debug.LogError("Failed to initialize the backend");
            }
        });
    }
}