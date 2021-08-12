using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ReadInputCode : MonoBehaviour
{
    public static string input;
    string filename = "";
    void Start()
    {

        filename = Application.dataPath + "/test.csv";
    }
    void Update()
    {
        
    }

    public void ReadInput(string s)
    {
        TextWriter tw = new StreamWriter(filename, false);
        tw.WriteLine("ID, Run, Adapted, Event, Event Data, Timestamp");
        tw.Close();
        input = s;
        Debug.Log(input);
  


    }
}
