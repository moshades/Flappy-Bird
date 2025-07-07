using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -10;
    public LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = FindFirstObjectByType<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.isGameOver == false)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }      
    }
}
