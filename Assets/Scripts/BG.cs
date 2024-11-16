using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class BG : MonoBehaviour
{
    public Sprite[] sprites; // Array of sprites to cycle through
    private SpriteRenderer spriteRenderer;
    private bool timer = false;
    private float timeCount = 0f;
    public GameObject blink;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!timer)
        {
            timeCount = Time.time;
            timer = true;
        }
        if (Time.time > timeCount + 10 && Blink.closed) { 
            timer = false;
            nextSprite();
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
}
