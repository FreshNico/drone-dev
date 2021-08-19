using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    public AudioSource playSound;
    public static int ringCount = 1;
    string filename = "";


    public void OnTriggerEnter(Collider collision)
    {
        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);


        if (collision.transform.tag == "Player")
        {

            tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "FPS Avg" + "," + TrackFrameRate.avgFramerate + "," + RegularTimer.currentTime + ",");
            tw.Close();
            Debug.Log("curent time: " + RegularTimer.currentTime);
            Debug.Log("avg framerate: " + TrackFrameRate.avgFramerate);

            playSound.Play();


        }

        
    }

}
