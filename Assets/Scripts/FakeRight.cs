using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeRight : MonoBehaviour
{
    private Vector3 n1;
    private int reset = 500;
    // Start is called before the first frame update
    void Start()
    {
        n1 = GetComponent<Rigidbody>().position;
        GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 3), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody>().position == n1)
        {
            reset--;
            if (reset == 0)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 3), ForceMode.Impulse);
                reset = 500;
            }
            

        }



    }
    private void OnCollisionEnter(Collision collision)
    {
            gameObject.transform.position = n1;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
