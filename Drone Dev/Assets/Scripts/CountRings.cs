using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CountRings : MonoBehaviour
{

    public void OnTriggerEnter(Collider collision)
    {

        if (collision.transform.tag == "Player")
        {

            EnterTrigger.ringCount+= 1;
            Scoreboard.score += 1;


            //Stops the counting of points
            Destroy(this);



        }
    }


}
