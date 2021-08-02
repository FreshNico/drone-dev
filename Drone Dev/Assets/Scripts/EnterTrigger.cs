using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{

    public void OnTriggerEnter(Collider collision)
    {

        if (collision.transform.tag == "Player")
        {
           
            Scoreboard.score += 1;
        }
    }

}
