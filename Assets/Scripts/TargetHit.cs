using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("TargetHit Started");
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody>().velocity != new Vector3(0, 0, 0))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        if (Timer.timerStop)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left Hand" || collision.gameObject.name == "Right Hand")
        {
            //Debug.Log("Target Hit");
            GameManager.instance.AddPoint();
        }
    }
}
