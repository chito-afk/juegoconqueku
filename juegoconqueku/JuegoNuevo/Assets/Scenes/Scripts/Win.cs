using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(GameObject.Find("WaterDoor").GetComponent<WaterDoorCollision>().counter);

		if (GameObject.Find("WaterDoor").GetComponent<WaterDoorCollision>().counter == 2){
			Debug.Log("You Win!");
			
		}
	}
}
