using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public int count = 0;

    public GameObject doorLeft;
    public GameObject keyPad;
    public GameObject doorRight;
    public AudioSource doorOpen;



    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "pickup")
        {
            Destroy(other.gameObject);
            count = count + 1;
        }

        if (count == 6)
        {

            doorOpen.Play();
            Destroy(doorLeft);
            Destroy(doorRight);
            Destroy(keyPad);
        }

    }



}