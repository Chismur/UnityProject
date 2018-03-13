using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {

	public Transform MyHand;
	public Rigidbody TheObject;

	// Use this for initialization
	void Start () {
		TheObject.transform.parent = MyHand.transform;
		TheObject.transform.localPosition = MyHand.transform.localPosition;
	}
	

}
