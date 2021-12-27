using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D player;
    public float speed = 100f;
    public float jump = 300f;
    private bool isJumping = false;

    SpriteRenderer spriteRenderer;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
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
                anim.SetBool("isPlayerJumping", true);
            }
        }

        if (Input.GetButton("Horizontal")) 
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1; //flip

        if (player.velocity.normalized.x == 0)
            anim.SetBool("isPlayerWalking", false);
        else
            anim.SetBool("isPlayerWalking", true);

        if (player.velocity.y < 0)
        {
            //Debug.DrawRay(player.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(player.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
            
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.6f)
                {
                    anim.SetBool("isPlayerJumping", false);
                    //Debug.Log(rayHit.collider.name);
                }
            }
        }
    }

}
