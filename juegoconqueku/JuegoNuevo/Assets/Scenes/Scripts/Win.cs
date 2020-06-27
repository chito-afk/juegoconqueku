using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

	private bool MyFunctionCalled = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find("WaterDoor").GetComponent<WaterDoorCollision>().counter == 2){
				if(MyFunctionCalled == false){
					MyFunctionCalled = true;
					Debug.Log("You Win!");
					SceneManager.LoadScene("Victory", LoadSceneMode.Single);
					GameObject.Find("NextLevel").GetComponent<NextLevel>().nextLevel += 1;
			}
		}
	}
}
