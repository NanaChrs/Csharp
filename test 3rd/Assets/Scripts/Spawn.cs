using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 spawnPosition;

    void Start()
    {
        spawnPosition = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -50)
        {
            transform.position = spawnPosition;
        }
    }
}
