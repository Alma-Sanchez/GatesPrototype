using UnityEngine;
using System.Collections;

public class towerScript : MonoBehaviour {

	public int currentHealth = 20;

	// Use this for initialization
	void Start () {

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "takeDamage") {
			currentHealth -= 1;
			}
		}

	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0){
			currentHealth = 0;
			Destroy(gameObject);
		}
	}
	void OnGUI(){
		GUI.Box(new Rect(51,25,135,25),"Tower 1 health: "+currentHealth.ToString("f0"));
	}	
}