using UnityEngine;
using System.Collections;

public class heavenScript : MonoBehaviour {
	//Heaven Health
	public int heavevnHealth = 50;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="takeDamage"){
			heavevnHealth -=1;

		}

	}

	// Update is called once per frame
	void Update () {
		if (heavevnHealth <= 0) {
			Destroy(gameObject);
		}
	}

}
