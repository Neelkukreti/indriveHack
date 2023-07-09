using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimate : MonoBehaviour
{
    public GameObject button; // Reference to the button GameObject
    public float delay = 4f; // Delay in seconds before the button appears

    private float timer;
    private bool buttonVisible = false;
    public Vector3 targetSize;

    void Start()
    {
        // Disable the button at the beginning
        button.SetActive(false);
        timer = 0f;
    }

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if the delay time has passed and the button is not visible
        if (timer >= delay && !buttonVisible)
        {
            // Enable the button and set its initial scale to zero
            button.SetActive(true);
            button.transform.localScale = Vector3.zero;

            // Trigger the animation
            StartCoroutine(AnimateButtonAppearance());

            buttonVisible = true;
        }
    }

    IEnumerator AnimateButtonAppearance()
    {
        // Set the target scale for the button
        Vector3 targetScale = targetSize;

        // Define the animation duration
        float animationDuration = 0.5f;

        // Animation loop
        float elapsedTime = 0f;
        while (elapsedTime < animationDuration)
        {
            // Calculate the interpolation factor
            float t = elapsedTime / animationDuration;

            // Update the button scale using interpolation
            button.transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, t);

            // Increase the elapsed time
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        // Ensure the button scale is set to the final value
        button.transform.localScale = targetScale;
    }
}
