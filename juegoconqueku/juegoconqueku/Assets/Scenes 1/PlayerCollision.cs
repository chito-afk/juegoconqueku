using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterCollision : MonoBehaviour {

	private Scene scene;

	// Use this for initialization
	void Start () {
		scene = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D other) { 
			if (other.gameObject.tag == "Fire")
        {
			Application.LoadLevel(scene.name);
        }
    }
}
