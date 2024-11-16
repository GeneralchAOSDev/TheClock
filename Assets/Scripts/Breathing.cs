using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class Breathing : MonoBehaviour
{
    public GameObject breathObject; // The object to move with breathing motion

    // Define breathing parameters
    public float breathSpeed = 1.0f; // Speed of the breathing motion
    public float breathMagnitude = 0.5f; // Magnitude of the breathing motion

    // Start is called before the first frame update
    void Start()
    {
        // Start breathing animation
        StartBreathing();
    }

    // Update is called once per frame
    void Update()
    {
        // Breathing motion is handled by DOTween, no need for Update method
    }

    void StartBreathing()
    {
        // Create a loop to continuously breathe
        breathObject.transform.DOMoveY(breathMagnitude, breathSpeed).SetEase(Ease.InOutQuad).SetLoops(-1, LoopType.Yoyo);
    }
}
