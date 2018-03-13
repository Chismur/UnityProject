using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class FromVRTo2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (DeactivatorVR ("none"));
	}

	public IEnumerator DeactivatorVR(string s){
		VRSettings.LoadDeviceByName (s);
		yield return null;
		VRSettings.enabled = false;
	}
}
