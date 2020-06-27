﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	private bool MyFunctionCalled = false;
	public float nextLevel = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return)){
			if (MyFunctionCalled == false)
			{
				MyFunctionCalled = true;
				SceneManager.LoadScene("Level " + nextLevel, LoadSceneMode.Single);				
			}
		}
	}
}