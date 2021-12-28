using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControlAndSound : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float jump;

    [SerializeField]
    private AudioSource runAudio;

    [SerializeField]
    private AudioSource jumpAudio;

    [SerializeField]
    private AudioClip runClip;

    [SerializeField]
    private AudioClip jumpClip;

    private Rigidbody2D player;
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
            if (player.velocity.y == 0 && isJumping == false)
            {
                player.AddForce(new Vector2(0, jump), ForceMode2D.Force);
                isJumping = true;
                anim.SetBool("isCatJumping", true);

                if (!jumpAudio.isPlaying)
                {
                    jumpAudio.clip = jumpClip;
                    jumpAudio.Play();
                }
            }
        }

        if (Input.GetButton("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1; //flip

        if (player.velocity.normalized.x == 0)
            anim.SetBool("isCatWalking", false);
        else
        {
            anim.SetBool("isCatWalking", true);

            if (!runAudio.isPlaying && !Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                runAudio.clip = runClip;
                runAudio.Play();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isJumping = false;
            anim.SetBool("isCatJumping", false);
        }
    }
}
