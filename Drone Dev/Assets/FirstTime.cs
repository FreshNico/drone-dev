using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class FirstTime : MonoBehaviour
{
    public Text firstTime;
    GameManager timer;
    
    public  void Update()
    {

        firstTime.text = timer.timerText.ToString();
        
        


    }
}
