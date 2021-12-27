using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform left;

    [SerializeField]
    private Transform right;

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
        if (gameObject.transform.position.x < left.position.x)
            direction = 1f;
        else if (gameObject.transform.position.x > right.position.x)
            direction = -1f;

        gameObject.transform.position = new Vector3(gameObject.transform.position.x + Time.deltaTime * speed * direction, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
