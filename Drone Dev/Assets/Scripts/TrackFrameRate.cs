using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TrackFrameRate : MonoBehaviour
{
    string filename = "";


    public void Track()
    {
        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);

        int timefps = (int)RegularTimer.currentTime;

        Debug.Log("curent time: " + RegularTimer.currentTime);
        Debug.Log("avg framerate: " + RegularTimer.avgFramerate);

            
            //tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "FPS Avg" + "," + RegularTimer.avgFramerate + "," + ",");





       // tw.Close();



    }
    
}
