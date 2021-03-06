﻿using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 10f;
    [SerializeField] AudioClip[] collisionClips;
    private Vector2 paddleToBallVector;
    private bool launched;

    // Start is called before the first frame update
    void Start() {
        paddleToBallVector = transform.position - paddle.transform.position;
        launched = false;
    }

    // Update is called once per frame
    void Update() {
        if (!launched) {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LockBallToPaddle() {
        Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePosition + paddleToBallVector;
    }

    private void LaunchOnMouseClick() {
        if (Input.GetMouseButtonDown(0)) {
            Rigidbody2D rigibody = GetComponent<Rigidbody2D>();
            rigibody.velocity = new Vector2(xPush, yPush);
            launched = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (launched) {
            int item = Random.Range(0, collisionClips.Length);
            AudioClip clip = collisionClips[item];
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
