using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {

            Application.Quit();
        }
    }

}
