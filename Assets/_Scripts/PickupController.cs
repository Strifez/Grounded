using UnityEngine;
using System.Collections;

//Jason Huang 300818592
//Source: Professor Tom's FPS Game
//Last Modified: Nov,20,2015
//Description: PickUp Item Script

public class PickupController : MonoBehaviour {
	//Public Instances
	public GameController gameController; //reference to GameController script
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider otherCollider)
	{
		if (otherCollider.gameObject.CompareTag ("Player")) {
			Invoke ("ItemGone",0.5f);
			this.gameController.FoodSupply += 1;
			audioSource.Play ();
		}
	}

	void ItemGone(){
		Destroy (gameObject);
	}
}
