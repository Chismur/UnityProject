using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSelector : MonoBehaviour {
	
	//public event Action OnOver;
	public GameObject Object;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Rigidbody getCapsule(){
		return Object.GetComponent<Rigidbody> ();
	}
}
