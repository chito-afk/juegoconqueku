using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDoorCollision : MonoBehaviour {

	public GameObject FireBoy;

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
			var FireBoyRenderer = FireBoy.GetComponent<Renderer>();
			FireBoyRenderer.material.SetColor("_Color", Color.black);
		}
	}
}
