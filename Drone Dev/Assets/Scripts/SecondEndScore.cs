using UnityEngine.UI;
using UnityEngine;


public class SecondEndScore : MonoBehaviour
{
    public Text secondValue;


    public void Update()
    {
        secondValue.text = GameManager.secondScore.ToString();


    }
}
