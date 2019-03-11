using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public GameObject Player;
    public int sceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
