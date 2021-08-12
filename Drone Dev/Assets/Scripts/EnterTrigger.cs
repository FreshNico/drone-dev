using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    public AudioSource playSound;
    string filename = "";
    public void OnTriggerEnter(Collider collision)
    {
        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);

        if (collision.transform.tag == "Player")
        {
           
            Scoreboard.score += 1;
            playSound.Play();


            tw.WriteLine(ReadInputCode.input +"," + GameManager.levelCount + ","+ GameManager.adaptedRun+ "," + "Ring Complete" + "," + true + "," + RegularTimer.currentTime);

            tw.Close();


            //Stops the counting of points

            Destroy(this);



        }
    }

}
