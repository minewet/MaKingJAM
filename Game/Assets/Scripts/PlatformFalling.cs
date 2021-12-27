using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFalling : MonoBehaviour
{

    public float fall = 0.3f, destroy = 2f;
    Rigidbody2D pf;

    // Start is called before the first frame update
    void Start()
    {
        pf = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
	{
        Invoke("FallPlatform", fall);
    }

    void FallPlatform()
	{
        pf.isKinematic = false;
    }
}
