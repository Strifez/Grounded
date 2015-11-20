using UnityEngine;
using System.Collections;

//Jason Huang 300818592
//Source: Professor Tom's FPS Game
//Last Modified: Nov,20,2015
//Description: Hazards Script

public class HazardController : MonoBehaviour {
	//Public Instances
	public GameController gameController; //reference to GameController script

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter (Collider otherCollider)
	{
		if (otherCollider.gameObject.CompareTag ("Player")) {
			this.gameController.Life -= 10;

		}
	}
}
