using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//namespace StellarSkyDemo_mouse
//{

	public class CameraController_mouse : MonoBehaviour
	{

		public float Sensitivity;
		public bool YInvert;


		// Use this for initialization
		void Start () {

		}

		private void Update()
		{



			// マウスでカメラを回転させる
			float rotationY = Input.GetAxis("Mouse X") * Sensitivity;
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


		}

	}
//}