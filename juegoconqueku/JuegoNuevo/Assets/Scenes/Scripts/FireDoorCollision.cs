using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDoorCollision : MonoBehaviour {

	public Material black;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Fire")
		{
			GameObject.Find("WaterDoor").GetComponent<WaterDoorCollision>().counter += 1; ;
			GameObject.Find("FireBoy").GetComponent<FireMovement>().enabled = false;
			GameObject.Find("FireBoy").GetComponent<Renderer>().material = black;
		}
	}
}
