using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour // trouver solution quand initialPosition < z fin
{
    float initialPosition;
    int direction;
    float z;
    public float zfin;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position.z;
        z = initialPosition;

        if (zfin < initialPosition)
        {
            direction = 1;
        }
        else if (zfin > initialPosition)
        {
            direction = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 1)
        {
            if (z > zfin || z > initialPosition)
            {
                transform.Translate(0, 0, (float)-0.02);
            }
            else if (z <= zfin || z <= initialPosition)
            {
                direction = 0;
            }
        }
        else if (direction == 0) {
            if (z <= initialPosition || z <= zfin)
            {
                transform.Translate(0, 0, (float)0.02);
            }
            else if (z >= initialPosition || z >= zfin)
            {
                direction = 1;
            }
        }
        z = transform.position.z;
        
        
    }
}
