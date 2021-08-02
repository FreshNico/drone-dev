using UnityEngine.UI;
using UnityEngine;


public class FirstEndScore : MonoBehaviour
{
    public Text firstValue;


    public void Update()
    {
        firstValue.text = GameManager.firstScore.ToString();
        

    }
}
