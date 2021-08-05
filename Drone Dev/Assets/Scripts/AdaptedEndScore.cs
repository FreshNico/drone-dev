using UnityEngine.UI;
using UnityEngine;


public class AdaptedEndScore : MonoBehaviour
{
    public Text adaptedValue;


    public void Update()
    {
        adaptedValue.text = GameManager.firstadaptedScore.ToString();


    }
}
