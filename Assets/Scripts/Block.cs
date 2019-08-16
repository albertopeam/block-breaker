using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip destroyClip;
    [SerializeField] GameObject blockSparklesVFX;
    private Level level;

    private void Start() {
        level = FindObjectOfType<Level>();
        AddBreakableBlock();
    }

    private void AddBreakableBlock() {
        if (tag == "Breakable") {
            level.AddBlock();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (tag == "Breakable") {
            DestroyBlock();
            AddGamePoints();
        }        
    }

    private void DestroyBlock() {
        AudioSource.PlayClipAtPoint(destroyClip, Camera.main.transform.position);
        TriggerSparklesVFX();
        Destroy(gameObject);
        level.RemoveBlock();
    }

    private void AddGamePoints() {
        FindObjectOfType<GameStatus>().AddDestroyedBlockScore();
    }

    private void TriggerSparklesVFX() {
        GameObject cloneVFX = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(cloneVFX, 2);   
    }
}
