using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform CameraRig;
    public GameObject target1;
    public static int points = 0;
    public int totalTargets = 5;
    public int currentTargets= 0;
    public static bool timerStart=false;
    private void Awake()
    {
        instance = this;
    }

    public void AddPoint()
    {
        timerStart = true;
        if (!Timer.timerStop)
        {
            points += 1;
        }
        currentTargets -= 1;
        //Debug.Log("Scored a point. Current points is " + points);
    }
    public void startGame()
    {
        points = 0;
    }
    public void stopGame()
    {
        points = 0;
    }
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (currentTargets < totalTargets&&Timer.timerStop==false)
        {
            
            while(currentTargets< totalTargets)
            {
                createTarget();
                //Debug.Log("Current Target " + currentTargets);
            }
        }
    }
    void createTarget()
    {
        GameObject target = Instantiate(target1);
        float x = Random.Range(0, 3f);
        float y = Random.Range(0, 1.6f);
        float z = Random.Range(0, 4.2f);
        target.transform.position = new Vector3(-57f+x,10.1f+y,-21+z);
        currentTargets += 1;
    }
    
}
