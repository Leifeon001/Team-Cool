using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrucRun : MonoBehaviour
{
    public GameObject Instruc;
    CharacterMovement Char;
    CharacterController CC;

    private void Start()
    {
        CC = FindObjectOfType<CharacterController>();
        CC.enabled = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instruc.SetActive(false);
            Char = FindObjectOfType<CharacterMovement>();
            CC.enabled = true;
            Char.Play.SetBool("Start", true);
        }
    }
}
