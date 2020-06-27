using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoorCollision : MonoBehaviour {

	public float counter;
	public Material black;

	// Use this for initialization
	void Start()
	{
		counter = 0;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Water")
		{
			counter = counter + 1;
			GameObject.Find("WaterGirl").GetComponent<WaterMovement>().enabled = false;
			GameObject.Find("WaterGirl").GetComponent<Renderer>().material = black;
		}
	}
}

