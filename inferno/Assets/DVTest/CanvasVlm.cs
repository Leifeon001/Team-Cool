using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class CanvasVlm : MonoBehaviour
{
    [SerializeField] float volunmeNum;
    [SerializeField] AudioMixer audioMixerV;
    [SerializeField] Dropdown resolutionDropdown;
    Resolution[] resolutionsVar;

    void Start()
    {
        ResolustionControl();
    }

    public void VolunmeControl(float volume)
    {
        audioMixerV.SetFloat("AMVolumeP",volume);
    }

    public void QualityControl (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void ResolustionControl()
    {
        resolutionsVar = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutionsVar.Length; i++)
        {
            string option = resolutionsVar[i].width + "x" + resolutionsVar[i].height;
            options.Add(option);

            if (resolutionsVar[i].width == Screen.currentResolution.width && 
                resolutionsVar[i].height ==Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutionsVar[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, 0);
    }

    //public void FullScreenControl (bool isFullScreen)
    //{
    //    Screen.fullScreen = isFullScreen;
    //}

    //void Update()
    //{

    //}
}
