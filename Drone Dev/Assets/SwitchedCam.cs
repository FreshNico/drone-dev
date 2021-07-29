using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchedCam : MonoBehaviour
{
    public GameObject cam2;
    public bool camOn = false;



    public void SwitchCam()
    {
        if (camOn == false)
        {
            camOn = true;
            cam2.SetActive(camOn);
            
        }


    }
}
