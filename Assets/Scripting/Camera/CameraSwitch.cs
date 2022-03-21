using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private GameObject _CameraMain;
    [SerializeField] private GameObject _CameraDop;
    private bool _isSwitchCam;
    public void SwitchCamera()
    {
        if(_isSwitchCam == false)
        {
            _isSwitchCam = true;
        }
        else if(_isSwitchCam == true)
        {
            _isSwitchCam = false;
        }
        if(_isSwitchCam == false)
        {
            _CameraMain.active = true;
            _CameraDop.active = false;
        }
        if(_isSwitchCam == true)
        {
            _CameraMain.active = false;
            _CameraDop.active = true;
        }
    }
}
