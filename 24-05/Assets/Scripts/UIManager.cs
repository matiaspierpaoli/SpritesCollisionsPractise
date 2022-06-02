using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Camera mainCam;
    [SerializeField] private TMP_Text text;

    public void ChangeCameraBackgroundColor()
    {
        mainCam.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); 
    }

    public void ActivateText()
    {
        text.enabled = true;
    }

    public void DeactivateText()
    {
        text.enabled = false;
    }
}
