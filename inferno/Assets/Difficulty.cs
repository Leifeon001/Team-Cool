using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public int Speed;
    
    public void Click()
    {
        GameManager GM = FindObjectOfType<GameManager>();
        GM.CharSpd(Speed);
    }
}
