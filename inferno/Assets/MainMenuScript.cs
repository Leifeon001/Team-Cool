using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject Difficulty;
    public GameObject Level;
    //public GameObject Options;
    [Header("Levels")]
    public string Level1; 
    public string Level2;
    public string Level3;


    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        Difficulty.SetActive(false);
        Level.SetActive(false);
    }

    public void PlayClick()
    {
        MainMenu.SetActive(false);
        Difficulty.SetActive(true);
    }

    public void SelectedDiff()
    {
        Difficulty.SetActive(false);
        Level.SetActive(true);
    }

    public void OnBack()
    {
        if(Difficulty.activeSelf == true)
        {
            Difficulty.SetActive(false);
            MainMenu.SetActive(true);
        }
        else if(Level.activeSelf == true)
        {
            Level.SetActive(false);
            Difficulty.SetActive(true);
        }
    }

    public void LvOne()
    {
        SceneManager.LoadScene(Level1);
    }

    public void LvTwo()
    {
        SceneManager.LoadScene(Level2);
    }

    public void LvThree()
    {
        SceneManager.LoadScene(Level3);
    }
}
