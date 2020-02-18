using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("You Won!!!");
            GameManager GM = FindObjectOfType<GameManager>();
            GM.PlayerWon = true;
           //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
