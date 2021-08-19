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
    public TimeSpan time;

    public void Start()
    {
       
        
        Invoke("Update", rd);
        currentTime = 0;


    }

    public void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        time = TimeSpan.FromSeconds(currentTime);
        timerText.text = time.ToString(@"m\:ss\:ff");
        bestT = Time.time - currentTime;




    }

   

  

}

