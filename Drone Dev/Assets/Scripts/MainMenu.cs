using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static int id = 0;

    public void PlayGame()
    {
        id++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }


}
