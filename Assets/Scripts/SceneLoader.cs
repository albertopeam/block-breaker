using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour{

    public void LoadNextScene() {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadFirstScene() {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().Reset();
    }

    public void Quit() {
        Application.Quit();
    }

}