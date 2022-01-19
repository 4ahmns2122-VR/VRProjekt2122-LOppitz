using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int count = 0;

    public GameObject doorLeft;
    public GameObject keyPad;
    public GameObject doorRight;
    public AudioSource doorOpen;
    
    void Start()
    {

        

        

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "pickup")
        {
            Destroy(other.gameObject);
            count = count + 1;
        }

        if (count == 2)
        {

            doorOpen.Play();
            Destroy(doorLeft);
            Destroy(doorRight);
            Destroy(keyPad);
        }

    }

    void Update()
    {
        
    }
}
