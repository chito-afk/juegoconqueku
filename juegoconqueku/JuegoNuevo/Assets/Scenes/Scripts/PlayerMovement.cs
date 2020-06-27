using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour {

	public float speed;
	public float jumpVelocity;
	public Transform from;
	public Transform to;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("d") && !Input.GetKey("a"))
        {
			transform.position += transform.TransformDirection(Vector2.right) * Time.deltaTime * speed;
        }else if (Input.GetKey("a") && !Input.GetKey("d"))
        {
			transform.position += transform.TransformDirection(Vector2.left) * Time.deltaTime * speed;
        }
		if (Input.GetButtonDown("Jump"))
        {
			GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
		}
		transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, 0);
	}
}
