using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class scr_turnOn : MonoBehaviour
{
    public bool on = true;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<Renderer>().enabled = on;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("pop");
            on = !on;
            gameObject.GetComponent<Renderer>().enabled = on;
            gameObject.GetComponentInChildren<Light2D>().enabled = on;
        }

    }
}


