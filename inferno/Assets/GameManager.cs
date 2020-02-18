using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool PlayerDead;
    public bool PlayerWon;
    GameObject GameOver;
    void Start()
    {
        GameOver = GameObject.Find("WinScreen");
        if (GameOver == null)
        {
            Debug.LogError("GameOver Screen not found in Sceen");
        }
        else
        {
            GameOver.SetActive(false);
        }
    }

    private void Update()
    {
        if(PlayerDead == true || PlayerWon == true)
        {
            GameOver.SetActive(true);
            Text Temp = GameObject.Find("WinText").GetComponent<Text>();
            if (PlayerDead)
            {               
                Temp.text = "You've Died";
            }
            else if(PlayerWon)
            {
                Temp.text = "Yay! You did it.";
            }
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
