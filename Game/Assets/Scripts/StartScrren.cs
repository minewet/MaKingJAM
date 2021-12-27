using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScrren : MonoBehaviour
{
    [SerializeField] GameObject s1_asset;
    [SerializeField] GameObject s2_asset;
    [SerializeField] GameObject s3_asset;
    private bool s1 = false;
    private bool s2 = false;
    private bool s3 = false;
    [SerializeField] Text question;
    [SerializeField] InputField names_staff;
    [SerializeField] InputField names_cat;
    public string staffname = "";
    public string catname = "";

    // Start is called before the first frame update
    void Start()
    {
        s3_asset.SetActive(false);
        s2_asset.SetActive(false);
        s1_asset.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (s1 == false && Input.GetMouseButtonDown(0))
        {
            s1 = true;
            s1_asset.SetActive(false);
        }

        if (s1 == true)
        {
            s2_asset.SetActive(true);
            question.text = "집사의 이름은 무엇인가요?";
            staffname = names_staff.text;
            if (staffname != "" && Input.GetKeyDown(KeyCode.Return))
            {
                s2 = true;
                s2_asset.SetActive(false);
            }
        }

        if (s2 == true)
        {
            s3_asset.SetActive(true);
            question.text = "고양이의 이름은 무엇인가요?";
            catname = names_cat.text;
            if (catname != "" && Input.GetKeyDown(KeyCode.Return))
            {
                s3 = true;
                s3_asset.SetActive(false);
            }
        }

        if (s3 == true)
        {
            SceneManager.LoadScene("Chapter1");

        }
    }

}
