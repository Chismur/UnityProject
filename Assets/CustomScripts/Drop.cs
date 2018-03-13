using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

	public Rigidbody TheObject;
	public Transform NewPlace;

	// Use this for initialization
	void Start () {
		TheObject.transform.parent = null;
		TheObject.transform.localPosition = NewPlace.transform.localPosition;
	}

}
