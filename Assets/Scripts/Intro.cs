using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public string nextScene; // Name of the scene you want to switch to

    void Start()
    {
        Invoke("ChangeScene", 5f); // Invoke the ChangeScene() method after 2 seconds
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(nextScene); // Load the next scene
    }
}
