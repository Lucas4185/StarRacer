using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject cubePrefab;
    public float spawnThreshold = 1f;


    private float spawnTimer = 0;
    public AudioClip saw;


    private void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
            
        }


    }
   

        private void SpawnCube()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-7.0f, 7.0f), 200, -3);
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        spawnTimer = -3;


    }

}
