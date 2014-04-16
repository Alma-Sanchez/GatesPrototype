using UnityEngine;
using System.Collections;

public class ScoreAndHealth : MonoBehaviour {
	public float overallScore;

	void Start () {
	}

	void Update () {
		overallScore = Time.deltaTime;
	}
	void OnGui(){
		GUI.Box(new Rect(20,15,300,50),"Score: "+overallScore.ToString("f0"));
	}
}
