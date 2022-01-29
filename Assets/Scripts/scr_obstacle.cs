using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class scr_obstacle : MonoBehaviour
{
    // public Transform player;

    public float maxDistance = 2;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        var distancePlayer = Vector2.Distance(scr_player.Instance.transform.position, transform.position);

        // if ((Math.Abs(player.transform.position.x- gameObject.transform.position.x)  <= 2) && 
        //     (Math.Abs(player.transform.position.y - gameObject.transform.position.y) <= 1 ))

        if (distancePlayer <= maxDistance)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
    }
}
