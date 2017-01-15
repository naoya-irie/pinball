using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brightnessregulator : MonoBehaviour {
    Material myMaterial;
    private float minEmission = 0.3f;
    private float magEmission = 2.0f;
    private int degree = 0;
    private int speed = 10;
    Color defaultColor = Color.white;
    void Start()
    {if (tag == "smallstartag")
    {this.defaultColor = Color.white;}
    else if (tag == "large startag")
    {this.defaultColor = Color.yellow;}
    else if (tag == "smallcloudtag" || tag == "largecloud tag")
    {this.defaultColor = Color.blue;}
    this.myMaterial = GetComponent<Renderer>().material;
    myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);}
    void Update()
    {if (this.degree >= 0)
    {Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
    myMaterial.SetColor("_EmissionColor", emissionColor);
    this.degree -= this.speed;}}
    void OnCollisionEnter(Collision other)
    {this.degree = 180;}}