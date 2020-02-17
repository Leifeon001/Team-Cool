using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CanvasVlm : MonoBehaviour
{
    [SerializeField] float volunmeNum;
    [SerializeField] AudioMixer audioMixerV;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolunmeControl(float volume)
    {
        //Debug.Log("VolunmeTest"); 
        //Debug.Log(volume);
        audioMixerV.SetFloat("AMVolumeP",volume);
    }
}
