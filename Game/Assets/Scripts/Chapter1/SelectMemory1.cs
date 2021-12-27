using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMemory1 : MonoBehaviour
{
    [SerializeField]
    private RespawnManager1 respawnManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // PlayerPrefs 첫번째 parameter에는 memory + 선택지 숫자(몇 번째 선택지인지)
    // 두번째 parameter에는 선택한 memory 이름을 넣어주세요.
    // 해당 챕터의 선택지 수 만큼 else if문을 복사해서 쓰시면 됩니다.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "memory1-1")
        {
            PlayerPrefs.SetString("memory1", "memory1-1");
            respawnManager.SetRespawnMemory("memory1-1");
        }
        else if (gameObject.name == "memory1-2")
        {
            PlayerPrefs.SetString("memory1", "memory1-2");
            respawnManager.SetRespawnMemory("memory1-2");
        }
        else if (gameObject.name == "memory16-1")
        {
            PlayerPrefs.SetString("memory2", "memory16-1");
            respawnManager.SetRespawnMemory("memory16-1");
        }
        else if (gameObject.name == "memory16-2")
        {
            PlayerPrefs.SetString("memory2", "memory16-2");
            respawnManager.SetRespawnMemory("memory16-2");
        }
    }
}
