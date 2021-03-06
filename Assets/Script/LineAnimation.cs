﻿
using UnityEngine;
using System.Collections;

public class LineAnimation : MonoBehaviour {

	private LineRenderer lineRenderer;
	private float count;
	private float howLong;

	public Transform saisyo;
	public Transform kokohe;
	public float lineDrawSpeed;


	private GameObject Line1;

	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetPosition (0, saisyo.position);
		//lineRenderer.SetWidth (.1f, .1f);
		lineRenderer.startWidth = .1f;
		lineRenderer.endWidth = .1f;

		howLong = Vector3.Distance (saisyo.position,kokohe.position);
	}

	void Update () {

			if (count < howLong) {
				count += .1f / lineDrawSpeed;

				float x = Mathf.Lerp (0, howLong, count);

				Vector3 pointA = saisyo.position;
				Vector3 pointB = kokohe.position;

				Vector3 pointAlongLine = x * Vector3.Normalize (pointB - pointA) + pointA;


				lineRenderer.SetPosition (1, pointAlongLine);
			}
		}


}
