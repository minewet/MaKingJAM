using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private float x;

    [SerializeField]
    private float y;

    private Transform cam;
    private Vector3 lower;
    private Vector3 higher;

    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.transform.GetChild(0);
        lower = new Vector3(x, y, -10f);
        higher = new Vector3(x, 0f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y > -0.5 || gameObject.transform.position.y < -4)
        {
                cam.localPosition = Vector3.Lerp(cam.localPosition, higher, Time.deltaTime);
        }
        else
        {
            cam.localPosition = Vector3.Lerp(cam.localPosition, lower, Time.deltaTime);
        }
    }
}
