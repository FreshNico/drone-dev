using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    string filename = "";
    public void OnTriggerEnter(Collider collision)
    {
        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);

        if (collision.transform.tag == "Player")
        {

            tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "Ground Collision" + "," + true + ","+RegularTimer.currentTime);

            tw.Close();


        }

           



        }


    }
