using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAndDrop : MonoBehaviour {

	//public Rigidbody Object;
	public Transform TheHolder;
	public GameObject AllTheNodes;

	public void InMyHands(Rigidbody Object){
		Object.transform.parent = TheHolder.transform;
		Object.transform.localPosition = TheHolder.transform.localPosition;

		AllTheNodes.SetActive (true);
	}

	public void OnTheNodes(Rigidbody Object){
		Object.transform.parent = null;
		Object.transform.localPosition = TheHolder.transform.localPosition;

		AllTheNodes.SetActive (false);
	}
}
