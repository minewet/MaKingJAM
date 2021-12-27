using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 새로운 챕터로 들어왔을 때 챕터 시작 위치를 리스폰 위치로 정해주는 스크립트입니다.
public class StartSetting2 : MonoBehaviour
{
    // scene + 스테이지 번호로 바꾸어주세요.
    [SerializeField]
    private string scene2;

    [SerializeField]
    private RespawnManager2 respawnManager;


    // Start is called before the first frame update
    void Start()
    {
        respawnManager.SetRespawnMemory(scene2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
