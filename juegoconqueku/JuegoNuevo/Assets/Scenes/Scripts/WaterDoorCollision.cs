using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoorCollision : MonoBehaviour {

	public float counter;

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
		}
	}
}

