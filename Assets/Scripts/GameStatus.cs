using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

    [Range(0.1f, 3f)] [SerializeField] float gameSpeed = 1f;

    // Update is called once per frame
    void Update() {
        Time.timeScale = gameSpeed;
    }
}
