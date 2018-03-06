using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangedColor : MonoBehaviour {

	public Material noLooky;
	public Material eyeSpy;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material = noLooky;

	}

	public void TotallyWatching(){
		GetComponent<Renderer> ().material = eyeSpy;
	}

	public void NoLooking(){
		GetComponent<Renderer> ().material = noLooky;
	}
}

