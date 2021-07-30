using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public GameObject completeLevelUI;
    private static int levelCount = 0;
    private float restartDelay = 2f;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("RestartCourse", restartDelay);
        
        



    }

    public void RestartCourse()

    {
        levelCount++;
        Debug.Log("Attempt Number: " + levelCount);

        if (levelCount == 2)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           
        }
    }


}
