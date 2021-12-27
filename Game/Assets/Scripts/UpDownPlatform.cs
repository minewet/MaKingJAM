using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform up;

    [SerializeField]
    private Transform down;

    [SerializeField]
    private float speed;

    private float direction = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < down.position.y)
            direction = 1f;
        else if (gameObject.transform.position.y > up.position.y)
            direction = -1f;

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Time.deltaTime * speed * direction, gameObject.transform.position.z);
    }
}
