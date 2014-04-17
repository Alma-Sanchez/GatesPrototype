using UnityEngine;
using System.Collections;

public class heavenScript : MonoBehaviour {
	//Heaven Health
	public int heavenHealth = 50;

	// Use this for initialization
	void Start () {
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="takeDamage"){
			heavenHealth -=1;
		}
	}

	void OnGUI(){
		GUI.Box(new Rect(25,25,135,25),"Heaven health: "+heavenHealth.ToString("f0"));
	}

	// Update is called once per frame
	void Update () {
		if (heavenHealth <= 0) {
			Destroy(gameObject);
		}
	}
}
