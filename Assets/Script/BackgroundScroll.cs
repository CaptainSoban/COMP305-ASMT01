﻿/* Source File Name: BackgroundScroll.cs
 * Author: Xiaoyu Wang
 * Last Modified Date: Oct 5th 2015
 * Description: Make the background move.
 * Version: 2
 * 
 * Class: BackgroundScroll
 * Method: Initial
 * 
 * */
using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
        this.Initial();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 CurPos = new Vector3(0.0f, 0.0f, 0.0f);
        CurPos = gameObject.GetComponent<Transform>().position;
        CurPos.y = CurPos.y - speed;
        gameObject.GetComponent<Transform>().position = CurPos;

        //restart
        if (CurPos.y < -3333.0f) {
            this.Initial();
        }
	}
    void Initial() {
        Vector3 ini = new Vector3(0.0f, 3333.0f, 50.0f);
        gameObject.GetComponent<Transform>().position = ini;
    }
}
