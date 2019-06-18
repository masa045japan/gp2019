using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drawScore : MonoBehaviour {


	Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find ("Canvas/Text").GetComponent <Text>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score" + Score.score;
	}
}
