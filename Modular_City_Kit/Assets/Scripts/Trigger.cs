using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	bool  colliding;
	void  OnGUI (){
		if (colliding)
		{
			GUI.BeginGroup( new Rect(Screen.width/2, Screen.height/2, 100, 100));
			GUI.Label( new Rect(0,0,100,100), "You have Reached your destination");
			GUI.EndGroup();
		}
	}

	void  OnTriggerEnter ( Collider col  ){
		if (col.gameObject.CompareTag("Player"))
		{
			colliding = true;
		}
	}

	void  OnTriggerExit ( Collider col  ){
		colliding = false;
	} void  OnTriggerEnter (){
		Debug.Log("Player");
	}
}