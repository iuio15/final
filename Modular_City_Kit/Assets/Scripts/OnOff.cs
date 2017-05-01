using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour {

	bool  onoff;
	GameObject p;

	void  Update (){
		if (Input.GetKeyDown(KeyCode.P))
		{
			p.SetActive(!p.activeSelf);
		}
	}
}
