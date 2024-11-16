using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Blink : MonoBehaviour
{
    public GameObject upper;
    public GameObject lower;
    private Vector3 upperInitialPos;
    private Vector3 lowerInitialPos;
    public static bool closed = true;
    // Define the duration of the blink animation
    public float blinkDuration = 0.5f;

    // Define the amount to move on the y-axis
    public float yOffset = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Store initial positions
        upperInitialPos = upper.transform.position;
        lowerInitialPos = lower.transform.position;

        // Start the blinking animation
        StartCoroutine(Blinking());
    }

    IEnumerator Blinking()
    {
        while (true) // Infinite loop for continuous blinking
        {
            // Calculate target positions
            Vector3 upperTargetPos = upperInitialPos + Vector3.up * yOffset;
            Vector3 lowerTargetPos = lowerInitialPos + Vector3.down * yOffset;

            // Smoothly move the objects to the target positions
            upper.transform.DOMove(upperTargetPos, blinkDuration).SetEase(Ease.InOutQuad);
            lower.transform.DOMove(lowerTargetPos, blinkDuration).SetEase(Ease.InOutQuad);

            // Wait for the blink duration to complete
            yield return new WaitForSeconds(blinkDuration);
            closed = false;

            // Smoothly move the objects back to their initial positions
            upper.transform.DOMove(upperInitialPos, blinkDuration).SetEase(Ease.InOutQuad);
            lower.transform.DOMove(lowerInitialPos, blinkDuration).SetEase(Ease.InOutQuad);

            // Wait for the blink duration to complete
            yield return new WaitForSeconds(blinkDuration);

            closed = true;
            // Wait for a random amount of time before starting the next loop
            yield return new WaitForSeconds(Random.value * 5);
        }
    }
}
