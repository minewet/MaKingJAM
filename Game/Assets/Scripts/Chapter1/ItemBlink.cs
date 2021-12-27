using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlink : MonoBehaviour
{
    private Color color;
    private float direction = -1f;

    // Start is called before the first frame update
    void Start()
    {
        color = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<SpriteRenderer>().color.a >= 1f)
        {
            direction = -1f;
        }
        else if (gameObject.GetComponent<SpriteRenderer>().color.a <= 0.3f)
        {
            direction = 1f;
        }
        gameObject.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, gameObject.GetComponent<SpriteRenderer>().color.a + Time.deltaTime * direction);
    }

}
