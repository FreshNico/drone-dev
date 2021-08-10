using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdaptedTimer : MonoBehaviour
{

    public float timeValue = 0;
    //private float restartDelay = 2f;
    public Text timerText;

    public void Update()
    {

        timeValue += Time.deltaTime;

    

            DisplayTime(timeValue);
       

    }

    public void DisplayTime(float timeToDisplay)
    {

        float mins = 0;
        

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", mins, seconds);



    }




    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Scoreboard.score = 0;
    }
}
