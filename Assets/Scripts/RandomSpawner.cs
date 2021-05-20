using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] flyingObjects;
    private float spawnPosY = 7.5f;
    private float spawnPosX = 2f;
    private float Timer = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0) 
        {
        
        int spawnIndex = Random.Range(0, flyingObjects.Length);
        Instantiate(flyingObjects[spawnIndex], new Vector3(Random.Range(-spawnPosX, spawnPosX), spawnPosY, -2.25f), flyingObjects[spawnIndex].transform.rotation);
        Timer = 2f;
        }
    }
}
