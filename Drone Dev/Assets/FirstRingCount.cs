using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FirstRingCount : MonoBehaviour
{
    string filename = "";
    int ringID = 1;

    public void OnTriggerEnter(Collider collision)
    {
        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);


        if (collision.transform.tag == "Player")
        {
            tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "Ring Complete" + "," + ringID + "," + RegularTimer.currentTime);

            tw.Close();



            //Stops the counting of points
            Destroy(this);



        }
    }


}
