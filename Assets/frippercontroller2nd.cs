using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frippercontroller2nd : MonoBehaviour {
    private HingeJoint myHingeJoynt;
    private float defaultAngle = 20;
    private float flickAngle = -20;
    private float centre = Screen.width / 2;
    void Start()
    {this.myHingeJoynt = GetComponent<HingeJoint>();
     SetAngle(this.defaultAngle);}
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.touches[i];
            if (touch.position.x < centre && "leftfrippertag" == tag)
            {
                if (touch.phase == TouchPhase.Began)
                { SetAngle(this.flickAngle); }
                if (touch.phase == TouchPhase.Ended)
                { SetAngle(this.defaultAngle); }

            }
            if (touch.position.x > centre && "rightfrippertag" == tag)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    SetAngle(this.flickAngle);
                }
                if (touch.phase == TouchPhase.Ended)
                { SetAngle(this.defaultAngle); }
            }
        }
    }
    
    public void SetAngle(float angle)
    {JointSpring jointSpr = this.myHingeJoynt.spring;
     jointSpr.targetPosition = angle;
     this.myHingeJoynt.spring = jointSpr;}}