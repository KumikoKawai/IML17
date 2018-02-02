using UnityEngine;
using System.Collections;

public class MAKELINE_SCRIPT : MonoBehaviour {


 void Update () {

  if(TouchTest.touch == 1){
  // LineRenderer（親オブジェクト）を生成
  GameObject prefab = (GameObject)Resources.Load("MAKELINEOBJECT");
  Instantiate(prefab);
	return;
		}
	}

}
