using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 떨어져서 특정 영역에 닿으면 리스폰 되도록 하는 스크립트입니다.
// 복사해서 각 챕터 번호를 붙여서 저장한 후 사용하세요.
public class RespawnTrigger2 : MonoBehaviour
{
    // RespawnManager를 각자 저장한 스크립트 이름에 맞게 수정하세요. 예를들면 RespawnManager1 이런식입니다.
    [SerializeField]
    private RespawnManager2 respawnManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        respawnManager.Respawn();
    }
}
