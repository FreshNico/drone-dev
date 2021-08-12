using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ReadInputCode : MonoBehaviour
{
    public static string input;
    void Start()
    {
       
        
    }
    void Update()
    {
        
    }

    public void ReadInput(string s)
    {
        input = s;
        //string filename = "";
        //filename = Application.dataPath + "/test.csv";

        //TextWriter tw = new StreamWriter(filename, false);
        //tw.WriteLine("ID");
        //tw.WriteLine(input);
        //tw.Close();
        Debug.Log(input);
  


    }
}
