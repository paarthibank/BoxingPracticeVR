using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PunchForce : MonoBehaviour
{
    TextMeshPro punchSpeed; 
    // Start is called before the first frame update
    void Start()
    {

        punchSpeed = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        punchSpeed.SetText(string.Format("{0:0.000}",GameObject.Find("Punching bag").GetComponent<PunchingBag>().power));
    }
}
