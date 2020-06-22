using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoorCollision : MonoBehaviour {

	public GameObject WaterGirl;
	public Material Negro;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Water")
		{
			WaterGirl.GetComponent<MeshRenderer>().material = Negro;
		}
	}
}

