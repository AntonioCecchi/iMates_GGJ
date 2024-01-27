using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Ball;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
           Instantiate(Ball, SpawnPoint.position, SpawnPoint.rotation);
        }
    }
}
