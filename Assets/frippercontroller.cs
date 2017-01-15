using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frippercontroller : MonoBehaviour {
    private HingeJoint myHingeJoynt;
    private float defaultAngle = 20;
    private float flickAngle = -20;
    void Start()
    {this.myHingeJoynt = GetComponent<HingeJoint>();
     SetAngle(this.defaultAngle);}
    void Update()
    {if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "leftfrippertag")
    {SetAngle(this.flickAngle);}
    if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "rightfrippertag")
    {SetAngle(this.flickAngle);}
    if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
    {SetAngle(this.defaultAngle);}}
    public void SetAngle(float angle)
    {JointSpring jointSpr = this.myHingeJoynt.spring;
     jointSpr.targetPosition = angle;
     this.myHingeJoynt.spring = jointSpr;}}