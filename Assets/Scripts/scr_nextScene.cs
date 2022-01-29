using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_nextScene : MonoBehaviour
{   
    [Scene]
    public int scene;
    // Start is called before the first frame update

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Any Message");
            SceneManager.LoadScene(scene);
        }

    }
}
