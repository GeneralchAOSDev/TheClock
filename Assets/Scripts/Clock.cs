using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Sprite[] sprites; // Array of sprites to cycle through
    private SpriteRenderer spriteRenderer;
    public GameObject blink;
    private GameObject lilHand;
    private GameObject bigHand;
    private int clickTime;
    private int min;
        private float hour;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        lilHand = GameObject.Find("lilHand") ;
        bigHand = GameObject.Find("bigHand");      
        nextSprite();
        Tick();

        //Debug.Log("DEBUG: Clicks = " + tempClick);
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            Tick();
        }
            
        
    }

    private void nextSprite()
    {
        // Randomly select a sprite from the array
        int randomIndex = Random.Range(0, sprites.Length);
        Sprite newSprite = sprites[randomIndex];

        // Assign the new sprite to the SpriteRenderer
        spriteRenderer.sprite = newSprite;
    }

    private void Tick()
    {
        
         
        min = (PlayerPrefs.GetInt("Clicks")) * 10;
        hour = min / 12f;
        Debug.Log("Number of Clicks: " + (PlayerPrefs.GetInt("Clicks")));
        Debug.Log("Minutes: " + min);
        Debug.Log("Hours: " + hour);
        bigHand.transform.eulerAngles = new Vector3(0, 0, min * -3);
        lilHand.transform.eulerAngles = new Vector3(0, 0, hour * -3);
        
    }
}
