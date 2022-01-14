using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton : MonoBehaviour
{
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "ObjectBlue")
        {
            Debug.Log("blue");
        }

        if (other.name == "ObjectGreen")
        {
            Debug.Log("green");
        }

        if (other.name == "ObjectRed")
        {
            Debug.Log("red");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
