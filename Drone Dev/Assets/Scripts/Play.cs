using UnityEngine.SceneManagement;
using UnityEngine;

public class Play : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
