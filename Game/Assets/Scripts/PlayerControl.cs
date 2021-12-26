using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D player;
    public float speed = 100f;
    public float jump = 300f;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        player.velocity = new Vector2(moveX, player.velocity.y);

		if (Input.GetKeyDown(KeyCode.Space))
		{
            if(player.velocity.y == 0)
			{
                player.AddForce(new Vector2(0, jump), ForceMode2D.Force);
                isJumping = true;
            }
        }     
    }
}
