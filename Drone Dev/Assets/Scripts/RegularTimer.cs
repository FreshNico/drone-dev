using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegularTimer : MonoBehaviour
{

    public float currentTime;
    public Text timerText;


    public void Start()
    {
        currentTime = 0;
    }

    public void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerText.text = time.ToString(@"m\:ss\:ff");


    }

  

}

