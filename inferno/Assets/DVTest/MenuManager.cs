using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] int testingInt;
    //[SerializeField] float[] testingArray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneManagement()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + testingInt);
        //SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(testingArray.Length).buildIndex);
    }

    public void ExitGame()
    {
        print("Leaving!");
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
