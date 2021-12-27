using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public GameObject Setting;
    public GameObject quitButton;

    public void OnclickButton()
    {
        if(PlayerPrefs.GetFloat("oncePlayed") > 0.0f)
        {
            PlayerPrefs.SetFloat("OncePlayed", 0.0f);
        }
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        Setting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Setting.activeSelf)
            {
                Setting.SetActive(false);
            }
            else
            {
                Setting.SetActive(true);
            }

        }
    }
}
