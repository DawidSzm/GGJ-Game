using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class scr_keyOpen : MonoBehaviour
{
    public GameObject gameobject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Math.Abs(gameobject.transform.position.x - gameObject.transform.position.x) <= 2) &&
            (Math.Abs(gameobject.transform.position.y - gameObject.transform.position.y) <= 1))
        {
            GameObject player = GameObject.Find("Player");
            scr_playerMovement keyCheck = player.GetComponent<scr_playerMovement>();
            if (Input.GetKeyDown(KeyCode.E) && keyCheck.key)
            {
                Destroy(gameObject);
            }

        }


    }
}    
