using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    public AudioSource playSound;
    public static int ringCount = 1;


    public void OnTriggerEnter(Collider collision)
    {

        if (collision.transform.tag == "Player")
        {

            playSound.Play();


        }

        
    }

}
