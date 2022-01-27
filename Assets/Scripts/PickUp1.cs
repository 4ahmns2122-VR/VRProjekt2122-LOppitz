using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;


public class PickUp1 : MonoBehaviour
{
    public int count = 0;
    public AudioSource collect;
   // private XRController xr;


    public GameObject doorLeft;
    public GameObject keyPad;
    public GameObject doorRight;
    public AudioSource doorOpen;



    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "button") {
           
            Debug.Log("bzz");

            
        }

        if (other.tag == "pickup")
        {
            Destroy(other.gameObject);
            count = count + 1;
            collect.Play();
           
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