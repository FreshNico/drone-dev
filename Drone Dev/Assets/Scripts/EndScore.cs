using UnityEngine.UI;
using UnityEngine;

public class EndScore : MonoBehaviour
{

    public Text scoreText;
    


    public void Update()
    {

        scoreText.text = Scoreboard.score.ToString();

    }

}
