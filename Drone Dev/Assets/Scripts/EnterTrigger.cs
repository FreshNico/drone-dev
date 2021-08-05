using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    public AudioSource playSound;
    public void OnTriggerEnter(Collider collision)
    {

        if (collision.transform.tag == "Player")
        {
           
            Scoreboard.score += 1;
            playSound.Play();
            //Stops the counting of points
            Destroy(this);



        }
    }

}
