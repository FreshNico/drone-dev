using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    string filename = "";
    public int groundCollCount = 0;

    public void OnCollisionEnter(Collision other)
    {
        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);

        if (other.transform.tag == "Player")
        {
            Debug.Log("Crashed");
            groundCollCount++;


        }
    }




}


