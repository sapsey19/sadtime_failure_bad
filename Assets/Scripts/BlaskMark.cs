using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlaskMark : MonoBehaviour {
    public float despawnTime;

    void Start() {
        StartCoroutine(DespawnTime());
    }


    IEnumerator DespawnTime() {
        yield return new WaitForSeconds(despawnTime);
        Destroy(gameObject);
    }   
}
