using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField] int numBlocks;

    public void AddBlock() {
        numBlocks++;
    }

    public void RemoveBlock() {
        numBlocks--;
    }

}
