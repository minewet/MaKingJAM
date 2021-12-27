using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover3 : MonoBehaviour
{

    [SerializeField] GameObject route1; // 분기 1
    [SerializeField] GameObject route2;
    [SerializeField] GameObject route3; // 분기 2
    [SerializeField] GameObject route4;

    // ch3는 분기점 되는 아이템을 못 찾아서 못 넣었습니다! 찾아서 넣어주시면 감사하겠습니다.
    [SerializeField] GameObject item1; // 분기 1
    [SerializeField] GameObject item2;
    [SerializeField] GameObject item3; // 분기 2
    [SerializeField] GameObject item4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Management.E == 1)
        {
            route2.SetActive(false);
            item2.SetActive(false);
        }
        if (Management.E == 2)
        {
            route1.SetActive(false);
            item1.SetActive(false);
        }
        if (Management.F == 1)
        {
            route4.SetActive(false);
            item4.SetActive(false);
        }
        if (Management.F == 2)
        {
            route3.SetActive(false);
            item3.SetActive(false);
        }
    }
}
