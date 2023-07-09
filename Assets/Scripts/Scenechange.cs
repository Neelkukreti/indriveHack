using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{

    public string nextSceneName;

    void Start()
    {
        Button button = GetComponent<Button>(); // Get the Button component attached to this GameObject
        button.onClick.AddListener(ChangeScene); // Add a listener to the button's click event
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName); // Load the next scene
    }
}
