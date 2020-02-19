using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool PlayerDead;
    public bool PlayerWon;
    GameObject GameOver;
    [SerializeField] GameObject optionMenu;
    [SerializeField] CharacterController cc;
    [SerializeField] bool ccBool = true;

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

        //optionMenu = FindObjectOfType<OptMenuRefer>().gameObject;
        //optionMenu = GameObject.FindObjectOfType<OptMenuRefer>().gameObject;
    }

    private void Update()
    {
        if((PlayerDead == true || PlayerWon == true) && ccBool==true)
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
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionMenu.SetActive(true);
            ccBool = false;
            cc.enabled = false;
            //Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (ccBool == true)
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

    public void ExitOption()
    {
        optionMenu.SetActive(false);
        ccBool = true;
        cc.enabled = true;

    }
}
