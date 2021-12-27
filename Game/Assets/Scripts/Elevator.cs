using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    private Transform up;

    [SerializeField]
    private Transform down;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float time;

    private float direction = 1f;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((gameObject.transform.position.y < down.position.y || gameObject.transform.position.y > up.position.y) && count == 0)
        {
            StartCoroutine(Timer());
        }

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Time.deltaTime * speed * direction, gameObject.transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SetParent(gameObject.transform);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.transform.SetParent(null);
    }

    IEnumerator Timer()
    {
        count = 1;
        direction = 0f;
        yield return new WaitForSeconds(time);
        if (gameObject.transform.position.y < down.position.y)
        {
            direction = 1f;
        }
        else if (gameObject.transform.position.y > up.position.y)
        {
            direction = -1f;
        }
        yield return new WaitForSeconds(1f);
        count = 0;
    }
}
