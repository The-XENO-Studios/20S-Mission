using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameManagerReal gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameManager.hasWon = true;
        }
    }
}
