using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    [SerializeField] Text a;
    [SerializeField] Text b;
    [SerializeField] Text c;
    [SerializeField] Text d;
    [SerializeField] Text e;
    [SerializeField] Text f;
    private string staffname;
    private string catname;

    [SerializeField] GameObject ending;
    [SerializeField] GameObject menu;
    [SerializeField] AudioSource buttonClicked;

    // Start is called before the first frame update
    void Start()
    {
        staffname = PlayerPrefs.GetString("staffName");
        catname = PlayerPrefs.GetString("catName");
        ending.SetActive(true);
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Management.A == 1)
        {
            a.text = "임시보호 고양이었던 " + catname +"을 고민 끝에 " + staffname + "는 키우기로 했다.";
        }
        else if(Management.A == 2)
        {
            a.text = "길에 버려진 고양이었던 " + catname + "을 고민 끝에 " + staffname + "는 키우기로 했다.";
        }
        if(Management.B == 1)
        {
            b.text = catname + "이는 이불 테러를 하는 등 말썽도 부려 " + staffname + "는 초보 집사로 고생도 했다";
        }
        else if(Management.B == 2)
        {
            b.text = catname + "이는 다리를 자꾸 무는 등 말썽도 부려 " + staffname + "는 초보 집사로 고생도 했다";
        }
        if(Management.C == 1)
        {
            c.text = staffname + "는 " + catname + "덕에 많이 웃었다. 한편 현관문에 마중나온 " + catname + "을 보고 위로를 받기도 했다.";
        }
        else if (Management.C == 2)
        {
            c.text = staffname + "는 " + catname + "덕에 많이 웃었다. 한편 베개 옆에서 같이 자는 " + catname + "을 보고 위로를 받기도 했다.";
        }
        if(Management.D == 1)
        {
            d.text = "캣타워에 올라가 코리를 탁탁 치고 있는 " + catname + "를 보는 일상이 " + staffname + "는 행복하고 소중했다.";
        }
        else if (Management.D == 2)
        {
            d.text = "캣휠을 타고 난 후 지쳐 늘어져 있는 " + catname + "를 보는 일상이 " + staffname + "는 행복하고 소중했다.";
        }
        if(Management.E == 1)
        {
            e.text = "하지만, 세월이 지나 " + catname + "는 치아가 아파왔고" + staffname + "는 원하지 않는 이별을 준비해야 했다.";
        }
        else if (Management.E == 2)
        {
            e.text = "하지만, 세월이 지나 " + catname + "는 신장이 아파왔고" + staffname + "는 원하지 않는 이별을 준비해야 했다.";
        }
        if(Management.F == 1)
        {
            f.text = catname + "은 별이 되었고, 오랜 시간 후에 " + staffname + "는 고양이 보호소에서 봉사를 시작했다. 하지만 언제나 마음 속에는 " + catname +"가 있었다.";
        }
        else if (Management.F == 2)
        {
            f.text = catname + "은 별이 되었고, 오랜 시간 후에 " + staffname + "는 새로운 가족을 맞이했다. 하지만 언제나 마음 속에는 " + catname + "가 있었다.";
        }

        next();
    }

    void next()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ending.SetActive(false);
            buttonClicked.Play();
            menu.SetActive(true);
        }
    }

    public void HomeButton()
    {
        buttonClicked.Play();
        SceneManager.LoadScene("StartScene");
        Management.A = 0;
        Management.B = 0;
        Management.C = 0;
        Management.D = 0;
        Management.E = 0;
        Management.F = 0;
        Management.cat = 0;
        Management.staff = 0;
    }

    public void QuitButton()
    {
        buttonClicked.Play();
        Application.Quit();
    }
}
