using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    [SerializeField]
    private GameObject staff;

    [SerializeField]
    private GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        /*
        if (Management.staff == 0)
        {
            staff.SetActive(true);
            cat.SetActive(false);
        }
        else if (Management.staff == 3)
        {
            staff.SetActive(false);
            cat.SetActive(true);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
