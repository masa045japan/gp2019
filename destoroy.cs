using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collison)
	{
		Score.score++;
        Debug.Log(Score.score.ToString("D4"));
		Destroy (gameObject);
	}
}
