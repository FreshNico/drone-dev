using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RingCollision : MonoBehaviour
{
    string filename = "";
    int ringCollisionCount = 0;

    public void OnCollisionEnter(Collision collision)
    {


        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);

        if (collision.transform.tag == "Player")
        {
            ringCollisionCount++;

            //tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "Ring Collision" + "," + ringCollisionCount + ","+RegularTimer.currentTime);

            //tw.Close();


        }

           



        }


    }
