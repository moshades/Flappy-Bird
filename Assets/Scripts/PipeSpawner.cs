using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffest = 1;
    public LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
        logic = FindFirstObjectByType<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else if (logic.isGameOver == false)
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
            float lowestPoint = transform.position.y - heightOffest;
            float highestPoint = transform.position.y + heightOffest;
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    } 
}