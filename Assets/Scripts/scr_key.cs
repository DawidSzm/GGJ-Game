using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_key : MonoBehaviour
{
    private bool inRange = false;

    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            // GameObject player = GameObject.Find("Player");
            // scr_playerMovement keyCheck = player.GetComponent<scr_playerMovement>();
            scr_player.Instance.key = true;
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inRange = true;
        }
        
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inRange = false;
        }
    }
}
