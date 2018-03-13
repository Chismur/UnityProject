using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class From2DtoVr : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		StartCoroutine (ActivatorVR("cardboard"));
	}
	
	public IEnumerator ActivatorVR(string s){
		VRSettings.LoadDeviceByName (s);
		yield return null;
		VRSettings.enabled = true;
	}
}
