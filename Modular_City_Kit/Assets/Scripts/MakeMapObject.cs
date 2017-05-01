using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeMapObject : MonoBehaviour {

	public Image image;

	// Use this for initialization
	void Start () {

		MiniMapController.RegisterMapObject(this.gameObject, image);
	}

	// Update is called once per frame
	void Update () {

	}

	void onDestroy(){
		MiniMapController.RemoveMapObject(this.gameObject);
	}

}
