using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {
    // Pour chaque fruit, créer un prefab et le rajouter (via unity) dans la liste prefabsFruit
    // PS: les fruit doivent avoir un rigidbody2D et un collider2D (CA DOIT ETRE UN TRIGGER !!!)
    public GameObject[] prefabsFruit;
    public GameObject[] spawn;
    
    void Start() {
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits() {
        // Fait spawn un fruit toutes les X secondes (entre 1 et 2)
        while (true) {
            yield return new WaitForSeconds(Random.Range(1f, 2f));
            
            GameObject randomFruit = prefabsFruit[UnityEngine.Random.Range(0, prefabsFruit.Length)];
            GameObject randomSpawn = spawn[UnityEngine.Random.Range(0, spawn.Length)];
            
            Instantiate(randomFruit, randomSpawn.transform.position, Quaternion.identity);
        }
    }
}