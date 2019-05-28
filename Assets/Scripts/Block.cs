using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip destroyClip;

    private void OnCollisionEnter2D(Collision2D collision) {
        AudioSource.PlayClipAtPoint(destroyClip, Camera.main.transform.position);
        Destroy(gameObject);    
    }

}
