using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXcontrol : MonoBehaviour
{
    [SerializeField] AudioSource startPlayingSFX;
    [SerializeField] AudioSource clickButtonSFX;
    [SerializeField] AudioSource jumpSFX;
    [SerializeField] AudioSource runSFX;

    public void StartGameSound()
    {
        startPlayingSFX.Play();
    }
    public void ClickButtonSound()
    {
        clickButtonSFX.Play();
    }
    public void JumpSound()
    {
        jumpSFX.Play();
    }
    public void RunSound()
    {
        runSFX.Play();
    }

    //void Start()
    //{
    //    //startPlayingSFX = FindObjectOfType<SFXReferScript>().GetComponentInChildren<AudioSource>().GetComponent<AudioClip>().
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
