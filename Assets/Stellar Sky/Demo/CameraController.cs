using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace StellarSkyDemo
{

    public class CameraController : MonoBehaviour
    {

        public float Sensitivity;
        public bool YInvert;

		//加速度センサーの傾きを入れるベクトル
		private Vector3 acc_vec;


		// Use this for initialization
		void Start () {

		}

        private void Update()
		{


			/*
			// マウスでカメラを回転させる
			//public Vector3 acceleration = Input.acceleration;
			float rotationY = Input.GetAxis("Mouse X") * Sensitivity;
			//float rotationY = acceleration.x * Sensitivity;
			float rotationX = 0;
			if (YInvert)
			{
				rotationX = -Input.GetAxis("Mouse Y") * Sensitivity;
			}
			else
			{
				rotationX = Input.GetAxis("Mouse Y") * Sensitivity;
			}

			transform.Rotate(new Vector3(rotationX, rotationY));
			Vector3 ea = transform.eulerAngles;
			transform.eulerAngles = new Vector3(ea.x, ea.y, 0);
			*/



			//transform.rotation = Input.gyro.attitude;
			//transform.rotation = -Input.gyro.attitude;
			//transform.rotation = -Input.gyro.rotationRate.y;




			// ジャイロセンサーでカメラの向きを変更しています
			Input.gyro.enabled = true;
			if (Input.gyro.enabled)
			{
				Quaternion gyro = Input.gyro.attitude;
				this.transform.localRotation = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyro.x,-gyro.y, gyro.z, gyro.w));

			}


            
        }

    }
}