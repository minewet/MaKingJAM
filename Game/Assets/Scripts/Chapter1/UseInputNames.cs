using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseInputNames : MonoBehaviour
{
    [SerializeField]
    private string front;

    [SerializeField]
    private string back;

    [SerializeField]
    private bool isCat;

    private TextMesh text;
    private string humanName;
    private string catName;

    // Start is called before the first frame update
    void Start()
    {
        humanName = PlayerPrefs.GetString("staffName");
        catName = PlayerPrefs.GetString("catName");
        text = GetComponent<TextMesh>();

        if (isCat)
        {
            text.text = front + catName + back;
        }
        else
        {
            text.text = front + humanName + back;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
