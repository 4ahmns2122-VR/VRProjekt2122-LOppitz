using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;



public class ButtonPart1 : MonoBehaviour
{

    public int id = 1;
    public AudioSource press;
    public AudioSource wrong;
  
    public ButtonManager1 bManager;

    public AudioSource pickUp1, pickUp2, pickUp3, pickUp4, pickUp5;

    public GameObject doorLeft1;
    public GameObject keyPad1;
    public GameObject doorRight1;
    public AudioSource doorOpen1;

    public void OnTriggerEnter(Collider other)
    {

        if (other.name == "RightHandBaseController")
        {
           if (id == bManager.currentID)
            {
                bManager.currentID += 1;
                press.Play();

               
                if (bManager.currentID == 4)
                {
                    bManager.stopAudio = true;
                }

                if (bManager.currentID > 4)
                {
                    wrong.Play();
                    id = 1;
                }

                if (bManager.stopAudio == true)
                {
                    doorOpen1.Play();
                    Destroy(doorLeft1);
                    Destroy(doorRight1);
                    Destroy(keyPad1);

                    bManager.gameOne.Stop();
                    pickUp1.Play();
                    pickUp2.Play();
                    pickUp3.Play();
                    pickUp4.Play();
                    pickUp5.Play();
                }
            }
        }

    }



}