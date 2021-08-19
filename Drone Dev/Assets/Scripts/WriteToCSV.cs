using System.IO;
using System;
using UnityEngine;

public class WriteToCSV : MonoBehaviour
{
    string filename = "";
    public float currentTime;
    



    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/test.csv";
        WriteCSV();
             
        
    }



    public void WriteCSV()
    {
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);

        TextWriter tw = new StreamWriter(filename, true);
        
        tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "Start Run" +","  + true +  "," + 0);
        tw.Close();
        Destroy(this);
        

    }
}
