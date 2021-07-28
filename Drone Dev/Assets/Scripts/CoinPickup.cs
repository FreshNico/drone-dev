using UnityEngine;
using UnityEngine.UI;


public class CoinPickup : MonoBehaviour
{

    public static int collectable = 0;
    public GameObject drone;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            collectable += 1;
            Debug.Log("Coin Picked Up!" + collectable);
            Destroy(gameObject);
        }
    }
    


    
}
