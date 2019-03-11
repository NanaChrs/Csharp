using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    DeathZone deathzone;
    void Start()
    {
        deathzone = GameObject.Find("DeathZone").GetComponent<DeathZone>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            deathzone.respawnPosition = gameObject.transform.position;
        }
    }
}
