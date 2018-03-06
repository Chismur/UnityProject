using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderAhead : MonoBehaviour {

	public Animator Anime;

	// Use this for initialization
	void Start () {
		Anime = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Anime.Play ("CylinderGo");
	}
}
