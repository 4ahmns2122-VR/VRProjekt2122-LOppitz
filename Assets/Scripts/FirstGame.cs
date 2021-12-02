using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGame : MonoBehaviour
{
    public GameObject ObjectGreen;
    public GameObject ObjectRed;
    public GameObject ObjectBlue;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("im trigger");
        if (other.tag== "ObjectGreen")
        {
            Debug.Log("Green");
        }

        if (other.tag == "ObjectRed")
        {
            Debug.Log("Red");
        }

        if (other.tag == "ObjectBlue")
        {
            Debug.Log("Blue");
        }
    }

    
    void Update()
    {
        
    }
}
