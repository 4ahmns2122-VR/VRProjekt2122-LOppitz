using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButtonRed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.name == "RightHandBaseController")
        {
            Debug.Log("red");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
