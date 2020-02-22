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
    [SerializeField] ThirdPersonCameraController tpcc;
    [SerializeField] bool ccBool = true;
    public static int CharacterSpeed;

    //private void Awake()
    //{
    //    cc = FindObjectOfType<Player>().GetComponent<CharacterController>();
    //    tpcc = FindObjectOfType<Player>().GetComponentInChildren<ThirdPersonCameraController>();
    //}

    void Start()
    {
        GameOver = GameObject.Find("WinScreen");
        if (GameOver != null)
        {
            GameOver.SetActive(false);
        }

        //Finding Option Menu
        optionMenu = FindObjectOfType<OptMenuRefer>().gameObject;
        if (optionMenu != null)
        {
            optionMenu.SetActive(false);
        }

        //Finding references that are needed for GM
        cc = FindObjectOfType<Player>().GetComponent<CharacterController>();
        tpcc = FindObjectOfType<Player>().GetComponentInChildren<ThirdPersonCameraController>();
    }

    private void Update()
    {
        if (FindObjectOfType<MainMenuScript>() == null)
        {
            if ((PlayerDead == true || PlayerWon == true) && ccBool == true)
            {
                GameOver.SetActive(true);
                Text Temp = GameObject.Find("WinText").GetComponent<Text>();
                if (PlayerDead)
                {
                    Temp.text = "You've Died";
                }
                else if (PlayerWon)
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
                PlayerCheck();
                ccBool = false;
                cc.enabled = false;
                tpcc.enabled = false;
                Time.timeScale = 0;
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
    }

    public void ExitOption()
    {
        optionMenu.SetActive(false);
        PlayerCheck();
        ccBool = true;
        cc.enabled = true;
        tpcc.enabled = true;
        Time.timeScale = 1;
    }

    public void CharSpd(int Speed)
    {
        CharacterSpeed = Speed;
    }
   public int GetSpeed()
   {
        return CharacterSpeed;
   }

    public void PlayerCheck()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            cc = FindObjectOfType<Player>().GetComponent<CharacterController>();
            tpcc = FindObjectOfType<Player>().GetComponentInChildren<ThirdPersonCameraController>();
        }
    }
}
