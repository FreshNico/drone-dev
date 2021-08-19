using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
 
public class TrackFrameRate : MonoBehaviour
{

    public static float timer, refresh, avgFramerate;


    public void Update()
    {
     

        //FPS
        float timeLapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timeLapse;

        if (timer <= 0) avgFramerate = (int)(1f / timeLapse);

        
    }

    

}
