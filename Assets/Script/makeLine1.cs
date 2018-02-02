using UnityEngine;
using System.Collections;

public class makeLine1 : MonoBehaviour {

  LineAnimation line;
  GameObject Saisyo;
  GameObject Kokohe;
  GameObject LineRenderer_prefab;

 void Start () {

  // LineRendererを生成する
  GameObject prefab = (GameObject)Resources.Load("LineRenderer");
  Instantiate(prefab);
  LineRenderer_prefab = GameObject.Find("LineRenderer(Clone)/LineRenderer Object1");

  Debug.Log(LineRenderer_prefab);

  // lineにLineAnimationスクリプトのコンポーネントを代入
  Saisyo = GameObject.Find("Start1");
  Kokohe = GameObject.Find("Start2");

  line = LineRenderer_prefab.GetComponent<LineAnimation>();

  // LineAnimationのInspectorに代入
  line.saisyo = Saisyo.transform;
  line.kokohe = Kokohe.transform;


 }
}
