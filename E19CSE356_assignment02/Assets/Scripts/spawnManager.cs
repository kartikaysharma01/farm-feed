using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 4;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // // press S and spawn animals
        // if (Input.GetKeyDown(KeyCode.S)) {
        //     SpawnRandomAnimal();
        // }        
    }

    void SpawnRandomAnimal() {
        Vector3 spawnPos = new Vector3(Random.Range(-22,-10), 0, Random.Range(-10, 30));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
