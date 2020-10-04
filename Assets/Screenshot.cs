using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    [SerializeField]
    int _upscaling = 1;

    int _ss;

    void Start()
    {
        _ss = 0;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            ScreenCapture.CaptureScreenshot("screenshot" + _ss + ".png", _upscaling);
            _ss++;

            print("Screenshot number " + _ss + " has been captured.");
        }
    }
}
