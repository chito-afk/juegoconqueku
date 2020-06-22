using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoorCollision : MonoBehaviour {

	public GameObject WaterGirl;

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
			var WaterGirlRenderer = WaterGirl.GetComponent<Renderer>();
			WaterGirlRenderer.material.SetColor("_Color", Color.black);
		}
	}
}

