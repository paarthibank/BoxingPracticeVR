using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingBag : MonoBehaviour
{
    public int points;
    public string message;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!(collision.gameObject.name == "collision_box_13"))
        {
            power = collision.relativeVelocity.magnitude;
            if (collision.contacts[0].point.y >= 12 && collision.contacts[0].point.x <= -59 && collision.contacts[0].point.x >= -60)
            {
                message="Nice knockout punch";
                points += 100;
            }
            else if (collision.contacts[0].point.y >= 12)
            {
                message="Punch near face";
                points += 10;
            }
            else
            {
                message="Punch to body";
            }
            
        }
    }
}
