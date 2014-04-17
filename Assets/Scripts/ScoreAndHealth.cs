using UnityEngine;
using System.Collections;

public class ScoreAndHealth : MonoBehaviour {
	public float overallScore = 0;

	void Start () {
	}

	void Update () {
		overallScore++;
	}
	void OnGUI(){
		//GUI.Box(new Rect(20,25,300,300),"Score: "+overallScore.ToString);
	}
}