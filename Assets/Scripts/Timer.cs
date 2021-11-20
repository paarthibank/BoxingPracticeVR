using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    TextMeshPro timerDisplay;
    public float timer;
    public static bool timerStop = false;
    // Start is called before the first frame update
    void Start()
    {
        timerDisplay = GetComponent<TextMeshPro>();
        timerDisplay.SetText(string.Format("{0:0.00}", timer));

    }

    // Update is called once per frame
    void Update()
    {


        if (GameManager.timerStart)
        {
            timer -= Time.deltaTime;
            timerDisplay.SetText(string.Format("{0:0.00}", timer));
        }
        if (timer <= 0)
        {
            timerStop = true;
            timerDisplay.SetText("Points : "+GameManager.points.ToString());
        }
        
    }
}
