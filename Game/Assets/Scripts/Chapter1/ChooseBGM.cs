using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBGM : MonoBehaviour
{
    [SerializeField]
    private AudioClip staff;

    [SerializeField]
    private AudioClip cat;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if(Management.staff == 0)
        {
            audioSource.clip = staff;
        }
        else if(Management.staff == 3)
        {
            audioSource.clip = cat;
        }

        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
