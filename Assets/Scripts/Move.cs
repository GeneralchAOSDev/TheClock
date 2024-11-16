using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public string turnTo;
    public Color highlightColor = Color.yellow; // Color to highlight the object
    private Color originalColor; // Original color of the object
    private Renderer objectRenderer; // Renderer component of the object
    private bool isHovering = false; // Flag to track if the mouse is hovering
    private string SceneToLoad;
    //Carosel carosel = new Carosel();
   

    private void Start()
    {
        // Get the Renderer component attached to the object
        objectRenderer = GetComponent<Renderer>();
        // Store the original color of the object
        originalColor = objectRenderer.material.color;
        // Initially disable the renderer
        objectRenderer.enabled = false;
        
        
    }

    private void Update()
    {
        // Check if the mouse is hovering over the object
        if (isHovering)
        {
            // If the mouse is hovering and the renderer is disabled, enable it
            if (!objectRenderer.enabled)
            {
                objectRenderer.enabled = true;
                // Start the color tweening coroutine
                objectRenderer.material.DOColor(highlightColor, 3f); // Tween over 1 second
            }
        }
        else
        {
            // If the mouse is not hovering, disable the renderer and reset the color
            objectRenderer.enabled = false;
            objectRenderer.material.color = originalColor;
        }
    }

    private void OnMouseEnter()
    {
        // Set the flag to true when the mouse enters
        isHovering = true;
    }

    private void OnMouseExit()
    {
        // Set the flag to false when the mouse exits
        isHovering = false;
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(turnTo);
        //carosel.GetVal(turnVal);
    }

    

    /* private System.Collections.IEnumerator TweenColorToHighlight()
     {
         // Wait for approximately 3 seconds
         yield return new WaitForSeconds(3f);

         // Tween the color to the highlight color over time
         float elapsedTime = 0f;
         float duration = 1f; // Duration of the color tween
         while (elapsedTime < duration)
         {
             objectRenderer.material.color = Color.Lerp(originalColor, highlightColor, elapsedTime / duration);
             elapsedTime += Time.deltaTime;
             yield return null;
         }

         // Ensure the final color is set to the highlight color
         objectRenderer.material.color = highlightColor;
     }*/
}
