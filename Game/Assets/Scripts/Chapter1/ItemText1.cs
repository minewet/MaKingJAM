using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemText1 : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    private Transform text;
    private bool play;

    // Start is called before the first frame update
    void Start()
    {
        if(Management.staff == 0)
            text = gameObject.transform.GetChild(0);
        else if(Management.staff == 3)
            text = gameObject.transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.gameObject.SetActive(true);
        play = true;
    }

    // 맵 크기에 따라 collider 크기와 거리 조정만 하면 됩니다.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.transform.position.x - collision.transform.position.x > -1
            && gameObject.transform.position.x - collision.transform.position.x < 1)
        {
            text.GetComponent<TextMesh>().color = new Color32(0, 0, 0, 255);
        }
        else
        {
            text.GetComponent<TextMesh>().color = new Color32(0, 0, 0, 127);
        }

        audioSource.clip = clip;

        if (play)
        {
            audioSource.Play();
            play = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false);
    }
}
