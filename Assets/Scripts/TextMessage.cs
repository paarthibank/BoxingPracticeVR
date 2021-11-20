using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextMessage : MonoBehaviour
{
    GameObject msg;
    TextMeshPro text;
    private void Awake()
    {
        msg = GameObject.Find("Punching bag");
    }
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshPro>();
        text.SetText("Start");
        
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(msg.GetComponent<PunchingBag>().message);
        
    }
}
