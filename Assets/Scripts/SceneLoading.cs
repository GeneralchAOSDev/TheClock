using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{

    public string SceneToLoad;
    public void Quit()
    {
        Application.Quit();
        //Debug.Log("Quit!");
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneToLoad);
    }


    private void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown)
        {
            // Call the Play() method
            Play();
        }
    }

    // Start is called before the first frame update
}