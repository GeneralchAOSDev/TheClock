using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickCount : MonoBehaviour
{

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        PlayerPrefs.SetInt("Clicks", count);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Click();
        }
    }

    private void Click()
    {
        count++;
        //Debug.Log("DEBUG: Clicks counted " + count);
        PlayerPrefs.SetInt("Clicks", count);
        PlayerPrefs.Save();
    }
}
