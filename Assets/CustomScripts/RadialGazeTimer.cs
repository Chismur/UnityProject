using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialGazeTimer : MonoBehaviour {

	public float MyTime = 0f;
	public Transform RadialProgress;
	public string MagicWord;
	public GameObject StuffToDo;



	// Use this for initialization
	void Start () {
		RadialProgress.GetComponent<Image> ().fillAmount = MyTime;
	}
	
	// Update is called once per frame
	void Update () {
		MyTime += Time.deltaTime;

		RadialProgress.GetComponent<Image> ().fillAmount = MyTime/2;

		if (MyTime >= 2f) {
			DoStuff ();
		}
	}

	public void Resetinator(){
		MyTime = 0f;
		RadialProgress.GetComponent<Image> ().fillAmount = MyTime;
	}
		
	public void DoStuff(){
		if (MagicWord == ("HAND")){
		StuffToDo.GetComponent<GrabAndDrop>().InMyHands();
		}
		else if (MagicWord == ("NODE")){
			Resetinator ();
		StuffToDo.GetComponent<GrabAndDrop> ().OnTheNodes ();
		}
	}
}
