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
			/* original
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
			*/

			/*
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
			*/

			transform.rotation = Input.gyro.attitude;

			/*
            transform.Rotate(new Vector3(rotationX, rotationY));
            Vector3 ea = transform.eulerAngles;
            transform.eulerAngles = new Vector3(ea.x, ea.y, 0);
			*/
        }

    }
}