using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopUp : MonoBehaviour
{


    public RectTransform imageRectTransform; // Reference to the RectTransform of the image
    public float animationDuration = 1f; // Duration of the animation in seconds
    public float startYPosition = -200f; // Starting Y position of the image below the screen
    public float endYPosition = 0f; // Ending Y position of the image when fully visible

    private bool isAnimating = false; // Flag to track animation status
    private float timer = 0f; // Timer for the animation

    void Start()
    {
        // Set the initial position of the image below the screen
        Vector3 startPos = imageRectTransform.anchoredPosition;
        startPos.y = startYPosition;
        imageRectTransform.anchoredPosition = startPos;

        
    }


    void Update()
    {
        // Check if an animation is in progress
        if (isAnimating)
        {
            // Increment the timer based on the time since the last frame
            timer += Time.deltaTime;

            // Calculate the normalized time for the animation
            float normalizedTime = Mathf.Clamp01(timer / animationDuration);

            // Calculate the current Y position using interpolation
            float currentYPosition = Mathf.Lerp(startYPosition, endYPosition, normalizedTime);

            // Update the position of the image
            Vector3 newPosition = imageRectTransform.anchoredPosition;
            newPosition.y = currentYPosition;
            imageRectTransform.anchoredPosition = newPosition;

            // Check if the animation has finished
            if (normalizedTime >= 1f)
            {
                // Animation is complete, reset the timer and animation flag
                timer = 0f;
                isAnimating = false;
            }
        }
    }

    public void StartAnimation()
    {
        // Start the animation if it's not already in progress
        if (!isAnimating)
        {
            isAnimating = true;
        }
    }
}