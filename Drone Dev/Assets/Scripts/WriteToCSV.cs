using System.IO;
using UnityEngine;

public class WriteToCSV : MonoBehaviour
{
    string filename = "";



    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/test.csv";
        WriteCSV();
             
        
    }



    public void WriteCSV()
    {

        TextWriter tw = new StreamWriter(filename, false);
        tw.WriteLine("ID,First Score, Second Score, First Adapted Score, Second Adapted Score");
        tw.WriteLine(ReadInputCode.input + "," + GameManager.firstScore +"," + GameManager.secondScore + "," +
             GameManager.firstadaptedScore + "," + GameManager.secondadaptedScore);
        tw.WriteLine("ID, Time");
        tw.WriteLine(ReadInputCode.input + "," + GameManager.startTime);
        tw.Close();


    }
}
