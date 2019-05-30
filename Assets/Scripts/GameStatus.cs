using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

    [Range(0.1f, 3f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlock = 10;
    [SerializeField] int score = 0;

    // Update is called once per frame
    void Update() {
        Time.timeScale = gameSpeed;
    }

    public void AddDestroyedBlockScore() {
        score += pointsPerBlock;
    }
}
