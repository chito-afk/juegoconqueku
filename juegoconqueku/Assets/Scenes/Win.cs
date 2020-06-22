using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

	public GameObject FireBoy;
	public GameObject WaterGirl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (FireBoy.GetComponent<MeshRenderer>().material == WaterGirl.GetComponent<MeshRenderer>().material)
		{
			Debug.Log("You Win!");
        }
	}
}
