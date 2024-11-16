using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectHighlighter : MonoBehaviour
{
    public Color highlightColor = Color.yellow; // Color to highlight the object
    private Color originalColor; // Original color of the object
    private Renderer objectRenderer; // Renderer component of the object

    private void Start()
    {
        // Get the Renderer component attached to the object
        objectRenderer = GetComponent<Renderer>();
        // Store the original color of the object
        originalColor = objectRenderer.material.color;
    }

    private void OnMouseEnter()
    {
        // Change the object's color to the highlight color when the mouse enters
        objectRenderer.material.color = highlightColor;
        //Debug.Log("Mouse Entered");
    }

    private void OnMouseExit()
    {
        // Restore the object's original color when the mouse exits
        objectRenderer.material.color = originalColor;
    }
}
