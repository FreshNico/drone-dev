using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RegularTimer : MonoBehaviour
{

    public static float currentTime;
    public Text timerText;
    private float rd = 1.5f;
    public float bestT;
    string filename = "";
    TimeSpan time;

    public void Start()
    {
       
        filename = Application.dataPath + "/test.csv";
        
        Invoke("Update", rd);
        Write();
        currentTime = 0;




    }

    public void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        time = TimeSpan.FromSeconds(currentTime);
        timerText.text = time.ToString(@"m\:ss\:ff");
        bestT = Time.time - currentTime;

        
        



    }

    public void Write()
    {
        TextWriter tw = new StreamWriter(filename, true);



        Debug.Log("delta Time " + Time.deltaTime);
        Debug.Log("Time Time " + Time.time);
        Debug.Log("current time: " + currentTime);
        Debug.Log("bestT time: " + bestT);

        
        tw.WriteLine(ReadInputCode.input + ","+ GameManager.levelCount+ "," + GameManager.adaptedRun + "," + "End Run" + ","+ true + "," + 0.00);

        tw.Close();


    }

  

}

