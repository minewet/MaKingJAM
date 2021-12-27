using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] GameObject s1_asset;
    [SerializeField] GameObject s2_asset;
    [SerializeField] GameObject s3_asset;
    [SerializeField] GameObject s4_asset;
    [SerializeField] GameObject Setting_popup;
    private bool s1 = false;
    private bool s2 = false;
    private bool s3 = false;
    private bool s4 = false;
    [SerializeField] GameObject textObject;
    [SerializeField] Text question;
    [SerializeField] InputField names_staff;
    [SerializeField] InputField names_cat;
    [SerializeField] GameObject QuitButton;
    [SerializeField] GameObject SettingsButton;
    public string staffname = "";
    public string catname = "";

    // Start is called before the first frame update
    void Start()
    {
        Setting_popup.SetActive(false);
        s4_asset.SetActive(false);
        textObject.SetActive(false);
        s3_asset.SetActive(false);
        s2_asset.SetActive(false);
        s1_asset.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
     if (s1 == true)
        {
            textObject.SetActive(true);
            s2_asset.SetActive(true);
            question.text = "집사의 이름은 무엇인가요?";
            staffname = names_staff.text;
            PlayerPrefs.SetString("staffName", names_staff.text);
            if (staffname != "" && Input.GetKeyDown(KeyCode.Return))
            {
                s2 = true;
            }
        }

        if (s2 == true)
        {
            s2_asset.SetActive(false);
            s3_asset.SetActive(true);
            question.text = "고양이의 이름은 무엇인가요?";
            catname = names_cat.text;
            PlayerPrefs.SetString("catName", names_cat.text);
            if (catname != "" && Input.GetKeyDown(KeyCode.Return))
            {
                s3 = true;
            }
        }

        if (s3 == true)
        {
            s3_asset.SetActive(false);
            s4_asset.SetActive(true);
            question.text = "고양이 " + catname + "의 집사 " + staffname + "님, \n게임을 떠나볼까요?";
        }

    }

    public void PlayButtonDown()
    {
        s1 = true;
        s1_asset.SetActive(false);
    }

    public void ClickHere()
    {
        SceneManager.LoadScene("Chapter1");
    }

    public void QuitButtonDown()
    {
        Debug.Log("Quit Button Down");
        Application.Quit();
    }

    public void SettingButtonDown()
    {
        Debug.Log("Settings Button Down");
        Setting_popup.SetActive(true);
    }

    public void SettingBackButtonDown()
    {
        Setting_popup.SetActive(false);
    }

}
