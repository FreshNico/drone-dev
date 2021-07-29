using UnityEngine;
using UnityEngine.UI;


public class CoinPickup : MonoBehaviour
{

    public static int collectable = 0;
    public GameObject drone;
    public GameObject drone2;

    public GameObject firstcam;
    public Switched switched;
    public SwitchedCam switchCam;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            collectable += 1;
            
            //Instantiate(drone2,transform.position, transform.rotation);

            Destroy(drone);
            Destroy(firstcam);
            switched.Switch();
            switchCam.SwitchCam();
            
            Destroy(gameObject);
        }
    }
    


    
}
