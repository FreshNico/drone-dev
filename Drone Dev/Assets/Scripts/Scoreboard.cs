using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public static int score = 0;
    public GameObject drone;
    public Text scoreText;
  


    public void Update()
    {

        scoreText.text = (score).ToString();

    }

    

}
