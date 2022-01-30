using System;
using System.Collections;
using System.Collections.Generic;
using CGTK.Utilities.Singletons;
using UnityEngine;
using static UnityEngine.Physics2D;

[RequireComponent(typeof(Rigidbody2D))]

public class scr_player : MonoBehaviourSingleton<scr_player>
{
    public float speed = 5f;
    public float verticalSpeed = 2f;
    // private bool isJumping = false;
    private Rigidbody2D body;
    private new Collider2D collider;
    public LayerMask groundLayer;

    // public GameObject layerWhite;
    public GameObject layerBlack;
    

    public bool key = false;
    private bool isTop = true;
    // public Animation idle;
    // public Animation walk;
    // public Animation jump;
    // public Animation idle_black;
    // public Animation walk_black;
    // public Animation jump_black;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (body.velocity.y > 0.1f)
        // {
        //     isJumping = true; 
        //     Debug.Log("I'm here" + body.velocity.y);
        // }
        // else
        // {
        //     isJumping = false;
        //     Debug.Log("I'm here2");
        // }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
            // var player = gameObject.transform.localScale;
            // player.x = 1;
            // if (isTop)
            // {
            //     walk.Play();
            // }
            // else
            // {
            //     walk_black.Play();
            // }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // var player = gameObject.transform.localScale;
            // player.x = -1;
            //
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            // if (isTop)
            // {
            //     
            //     walk.Play();
            // }
            // else
            // {
            //     
            //     walk_black.Play();
            // }
        }

        if ((Input.GetKeyDown(KeyCode.Space)) && (IsGrounded))
        {
            // if (isTop)
            // {
            //     
            //     jump.Play();
            // }
            // else
            // {
            //     
            //     jump_black.Play();
            // }
            body.AddForce(new Vector2(0f, verticalSpeed), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isTop)
            {

                isTop = false;
            }
            else
            {
                isTop = true;
            }
           
            var localScaleBlack = layerBlack.transform.localScale;
            // var localScaleWhite = layerWhite.transform.localScale;

            localScaleBlack.y = -localScaleBlack.y;
            // localScaleWhite.y *= 1;
            
            layerBlack.transform.localScale = localScaleBlack;
            // layerWhite.transform.localScale = localScaleWhite;
                
        }

    }
    

    private bool IsGrounded
    {
        get
        {
            var bounds = collider.bounds;
            var hit = Raycast(bounds.center, Vector2.down, bounds.extents.y + 0.05f, layerMask:groundLayer);
            bool hasHit = (hit.collider != null);
            Debug.DrawRay(bounds.center, Vector2.down * (bounds.extents.y + 0.05f),
                color: (hasHit) ? Color.green:Color.red);
            return hasHit;
        }
        
    }
}