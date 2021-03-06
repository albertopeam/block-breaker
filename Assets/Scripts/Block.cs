﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip destroyClip;
    private Level level;

    private void Start() {
        level = FindObjectOfType<Level>();
        level.AddBlock();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        DestroyBlock();
        AddGamePoints();
    }

    private void DestroyBlock() {
        AudioSource.PlayClipAtPoint(destroyClip, Camera.main.transform.position);
        Destroy(gameObject);
        level.RemoveBlock();
    }

    private void AddGamePoints() {
        FindObjectOfType<GameStatus>().AddDestroyedBlockScore();
    }
}
