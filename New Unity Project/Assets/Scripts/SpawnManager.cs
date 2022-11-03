using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs; //Array to store balloon game object
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval); //Continuously spawns balloons with a start delay and interval array

    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange,xRange),0,0); //Get random position on x-axis
        int balloonIndex = Random.Range(0,balloonPrefabs.Length); //Pick a random balloon from the balloon array
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex], transform.rotation); //Spawn random balloon at spawn position

    

    }
}
