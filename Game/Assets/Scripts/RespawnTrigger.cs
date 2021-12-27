using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 떨어져서 특정 영역에 닿으면 리스폰 되도록 하는 스크립트입니다.
public class RespawnTrigger : MonoBehaviour
{
    [SerializeField]
    private RespawnManager respawnManager;

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
