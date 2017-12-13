using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	

public class accSensor : MonoBehaviour {

	//加速度センサーの傾きを入れるやつ
	private Vector2 acc_vec;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//加速度を取得
		//※加算しないとちょっとしか移動しませんよ！
		acc_vec.x += Input.acceleration.x * 1000;
		acc_vec.y += Input.acceleration.y * 1000;
		if (acc_vec != null) {
			transform.position = acc_vec;
		}
		/**
		//ちなみに一気に取得もできる
		acc_vec = Input.acceleration;
		**/
	}
}