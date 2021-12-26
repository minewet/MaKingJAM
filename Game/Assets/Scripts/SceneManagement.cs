using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public bool StartScreen = false;
    public bool Staff1 = false;
    public bool Staff2 = false;
    public bool Staff3 = false;
    public bool Cat1 = false;
    public bool Cat2 = false;
    public bool Cat3 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartScreen == true)
        {
            SceneManager.LoadScene("Chapter1");
        }
        if (Staff1 == true)
        {
            SceneManager.LoadScene("Chapter2");
        }
        if (Staff2 == true)
        {
            SceneManager.LoadScene("Chapter3");
        }
        if (Staff3 == true)
        {
            SceneManager.LoadScene("Chapter1");
        }
        if (Cat1 == true)
        {
            SceneManager.LoadScene("Chapter2");
        }
        if (Cat2 == true)
        {
            SceneManager.LoadScene("Chapter3");
        }
        if (Cat3 == true)
        {
            SceneManager.LoadScene("EndingScene");
        }
    }
}
