using UnityEngine;
using System.Collections;

public class makeLine : MonoBehaviour {
 void Start () {
  GameObject prefab = (GameObject)Resources.Load("LineRenderer");
  Instantiate(prefab,transform.position,transform.rotation);
 }
}
