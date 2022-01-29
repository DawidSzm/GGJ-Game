using UnityEngine;
using UnityEngine.SceneManagement;

public class resetButton : MonoBehaviour
{
    // public Object activeScene;
    void Start()
    {
        //Debug.Log("LoadSceneA");
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.R)) 
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
