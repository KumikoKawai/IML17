using UnityEngine;
using System.Collections;

public class TouchTest_Script : MonoBehaviour {

	GameObject M;

	void Start () {
	}

	void Update () {

		if ((0 < Input.touchCount) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
			//if (true) {
				GameObject p = (GameObject)Resources.Load("MakeLineRendererObject");
				Instantiate(p);
			//M = GameObject.Find("MakeLineRendererObject");
			//Instantiate(M);
		}

	}

}
