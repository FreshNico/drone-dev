using UnityEngine.UI;
using UnityEngine;


public class AdaptedEndScore2 : MonoBehaviour
{
    public Text adaptedValue;


    public void Update()
    {
        adaptedValue.text = GameManager.secondadaptedScore.ToString();


    }
}
