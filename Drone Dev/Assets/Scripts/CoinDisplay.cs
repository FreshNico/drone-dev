using UnityEngine.UI;
using UnityEngine;

public class CoinDisplay : MonoBehaviour
{
    public Text collectableText;

    public void Update()
    {

        collectableText.text = CoinPickup.collectable.ToString();

    }
}
