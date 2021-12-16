using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    public GameObject ObjectGreen;
    public GameObject ObjectRed;
    public GameObject ObjectBlue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "ObjectGreen")
        {
            Debug.Log("Green");
        }
        if (gameObject.name == "ObjectRed")
        {
            Debug.Log("Red");
        }
        if (gameObject.name == "ObjectBlue")
        {
            Debug.Log("Blue");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
