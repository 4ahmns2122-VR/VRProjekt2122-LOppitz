using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButtonBlue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.name == "RightHandBaseController")
        {
            Debug.Log("blue");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
