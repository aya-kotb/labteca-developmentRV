﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInputCanvasButtons : MonoBehaviour, TimedInputHandler {

	// Use this for initialization
	void Start () {
        //GetComponent<Renderer>().material.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleTimedInput()
    {
        Debug.Log("Click");
    }
}
