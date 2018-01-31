using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace StellarSkyDemo
{

    public class CameraController : MonoBehaviour
    {

        public float Sensitivity;
        public bool YInvert;


		// Use this for initialization
		void Start () {

		}

        private void Update()
		{

			// ジャイロセンサーでカメラの向きを変更しています
			Input.gyro.enabled = true;
			if (Input.gyro.enabled)
			{
				Quaternion gyro = Input.gyro.attitude;
				this.transform.localRotation = Quaternion.Euler(0, 0, 0) * (new Quaternion(-gyro.x,-gyro.y, gyro.z, gyro.w));

			}


            
        }

    }
}