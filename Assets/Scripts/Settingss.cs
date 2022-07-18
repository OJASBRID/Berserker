using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settingss : MonoBehaviour
{
    public void SetFullScreen(bool IsFullscreen)
    {
        Screen.fullScreen = IsFullscreen;
    }
    public void SetQuality(int QualityIndex)
    {

        QualitySettings.SetQualityLevel(QualityIndex);
    }
}
