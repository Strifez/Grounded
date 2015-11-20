using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Jason Huang 300818592
//Source: Professor Tom's FPS Game
//Last Modified: Nov,20,2015
//Description: Game Controller Script

public class GameController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public Text foodLabel;
	public Text lifeLabel;
	
	// PRIVATE INSTANCE VARIABLES
	private int _foodValue = 0;
	private int _liveValue = 100;
	
	// PUBLIC PROPERTIES
	public int FoodSupply { 
		get {
			return _foodValue;
		}
		set {
			_foodValue = value;
			this._updateHUD();
		}
	}
	
	public int Life {
		get {
			return _liveValue;
		}
		set {
			_liveValue = value;
			this._updateHUD();
		}
	}
	
	// Use this for initialization
	void Start () {
		this._updateHUD ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// PRIVATE METHODS
	private void _updateHUD() {
		this.foodLabel.text = "Food Supply: " + this._foodValue;
		this.lifeLabel.text = "Life: " + this._liveValue;
	}
}
