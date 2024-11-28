using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenFall : MonoBehaviour {
    void Update() {
        if (transform.position.y < -5f) {
            // Detruit si le joueur n'a pas pris le fruit
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // Le joueur récupère le fruit (il faut lui donner)
            Destroy(gameObject);
        }
    }
}
