using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bump : MonoBehaviour
{
    public GameObject Player;
    public float forceX;
    public float forceY;
    public float forceZ;
    private Vector3 force = new Vector3(0, 5, 5);

    Rigidbody rb;

    
    public void OnDrawGizmos()
    {
        Debug.DrawLine(this.transform.position, this.transform.position + force / Physics.gravity.magnitude, Color.red);
    }
    public void ApplyForceOnTriggerEnter(Collider other)
    {
       if(other.gameObject == Player)
        {
            rb = Player.GetComponent<Rigidbody>();
            rb.AddForce(force);
        }
    }
}
