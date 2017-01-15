using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballcontroller : MonoBehaviour
{private float visiblePosZ = -6.5f;
    private GameObject gameovertext;
    void Start()
    {this.gameovertext = GameObject.Find("gameovertext");}
    void Update()
    {if (this.transform.position.z < this.visiblePosZ)
    {this.gameovertext.GetComponent<Text>().text = "Game Over";}
    }}