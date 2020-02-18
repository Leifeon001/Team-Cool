using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{

    public string Main;
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager GM = FindObjectOfType<GameManager>();
        GM.PlayerDead = false;
        GM.PlayerWon = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(Main);
    }
}
