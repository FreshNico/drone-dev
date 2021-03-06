using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
    

public class GameManager : MonoBehaviour
{
   
    public GameObject completeLevelUI;
    public static int levelCount = 0;
    private float restartDelay = 1.5f;
    public static int firstScore = 0;
    public static int secondScore = 0;
    public static int firstadaptedScore = 0;
    public static int secondadaptedScore = 0;
    public static bool adaptedRun = false;

   
    

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("RestartCourse", restartDelay);
      
        
    }

    public void RestartCourse()

    {
        
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
            adaptedRun = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }

        
        else
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            

        }
        
     
    }


}
