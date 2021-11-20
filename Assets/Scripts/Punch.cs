using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Punch : MonoBehaviour
{

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Head hit %d" + score);
        if (collision.gameObject.name == "Left Hand")
        {
            score += 100;
            Debug.Log("Head hit %d" + score);

        }
        if (collision.gameObject.name == "Right Hand")
        {
            score += 100;
            Debug.Log("Head hit %d" + score);

        }

    }
}
