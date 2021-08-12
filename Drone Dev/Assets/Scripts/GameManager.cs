using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
    

public class GameManager : MonoBehaviour
{
   
    public GameObject completeLevelUI;
    private static int levelCount = 0;
    private float restartDelay = 1.5f;
    public static int firstScore = 0;
    public static int secondScore = 0;
    public static int firstadaptedScore = 0;
    public static int secondadaptedScore = 0;
    private MainMenu checkIfGameStart;
    public Text timerText;
    public static float startTime, elapseTime;
    //string filename = "";






    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("RestartCourse", restartDelay);
        
    }

    public void Start()
    {
        startTime = 0;

    }



    public void Update()
    {
        startTime = startTime + Time.deltaTime;
        TimeSpan timePlaying = TimeSpan.FromSeconds(startTime);
        timerText.text = timePlaying.ToString(@"m\:ss\:ff"); 
        
       



    }

    public void RestartCourse()

    {
        //filename = Application.dataPath + "/test.csv";
        levelCount++;
        


        Debug.Log("Attempt Number: " + levelCount);

        if (levelCount == 1)
        {
            firstScore = Scoreboard.score;
        }
        if (levelCount == 2)
        {
            secondScore = Scoreboard.score;
        }
        if (levelCount == 3)
        {
            firstadaptedScore = Scoreboard.score;
        }

        if (levelCount == 4)
        {
            secondadaptedScore = Scoreboard.score;
        }

        Scoreboard.score = 0;

        if (levelCount == 2 || levelCount == 4)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            //TextWriter tw = new StreamWriter(filename, true);
            //tw.WriteLine("ID, Time");
            //tw.WriteLine(ReadInputCode.input + "," + startTime);



        }
    }


}
