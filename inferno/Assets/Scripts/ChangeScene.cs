using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string Next;
   
    public void NxtLvl()
    {
        SceneManager.LoadScene(Next);
    }
}
