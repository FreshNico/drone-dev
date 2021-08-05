using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdaptedTimer : MonoBehaviour
{

    public float timeValue = 40;
    private float restartDelay = 2f;
    public Text timerText;

    public void Update()
    {
        
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;


                Invoke("Restart", restartDelay);

            }

            DisplayTime(timeValue);
       

    }

    public void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else
        {
            float mins = 0;
            //Calculate minutes but I do not think we will be needing minutes for the current course
            //mins = Mathf.FloorToInt(timeToDisplay / 60);

            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timerText.text = string.Format("{0:00}:{1:00}", mins, seconds);

        }


    }




    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Scoreboard.score = 0;
    }
}
