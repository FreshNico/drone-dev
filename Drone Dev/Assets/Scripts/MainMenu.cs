using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static int id = 0;
    public bool levelbegin = false;


    public void PlayGame()
    {
        levelbegin = true;
        id++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }

    public bool CheckIfGameStart()
    {
        if (levelbegin == true)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

}
