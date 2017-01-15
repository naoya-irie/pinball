using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretext : MonoBehaviour {
    int score = 0;
    Text score_text;
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "largestar tag")
        { score = score + 10; }
        if (other.transform.tag == "largecloud tag")
        { score = score + 20; }
        if (other.transform.tag == "smallcloudtag")
        { score = score + 5; }
        if (other.transform.tag == "smallstartag")
        { score = score + 15; }
    }
             void Update ()
             { GameObject scoreobject = GameObject.Find("scoretext");
               scoreobject.GetComponent<Text>().text = score.ToString(); } } 

		
	