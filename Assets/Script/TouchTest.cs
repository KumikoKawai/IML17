using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {

	public static int touch = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        if(OnTouchDown()){
            Debug.Log("タップされました");
        }
    }

    //スマホ向け そのオブジェクトがタッチされていたらtrue（マルチタップ対応）
    bool OnTouchDown() {
        // タッチされているとき
        if( 0 < Input.touchCount){
            // タッチされている指の数だけ処理
            for(int i = 0; i < Input.touchCount; i++){
                // タッチ情報をコピー
                Touch t = Input.GetTouch(i);
                // タッチしたときかどうか
                if(t.phase == TouchPhase.Began ){
                    //タッチした位置からRayを飛ばす
                    Ray ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit = new RaycastHit();
                    if (Physics.Raycast(ray, out hit)){
                        //Rayを飛ばしてあたったオブジェクトが自分自身だったら
                        if (hit.collider.gameObject == this.gameObject){
                            touch = 1;
														return true;
                        }
                    }
                }
            }
        }
        return false; //タッチされてなかったらfalse
    }
}
