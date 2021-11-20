using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gloves : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Comment in original occulus
        if(GetComponent<Rigidbody>().velocity!=new Vector3(0, 0, 0))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }

}
