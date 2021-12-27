using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover1 : MonoBehaviour
{

    [SerializeField] GameObject route1; // 분기 1
    [SerializeField] GameObject route2;
    [SerializeField] GameObject route3; // 분기 2
    [SerializeField] GameObject route4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Management.A == 1)
        {
            route2.SetActive(false);
        }
        if (Management.A == 2)
        {
            route1.SetActive(false);
        }
        if (Management.B == 1)
        {
            route4.SetActive(false);
        }
        if (Management.B == 2)
        {
            route3.SetActive(false);
        }
    }
}
