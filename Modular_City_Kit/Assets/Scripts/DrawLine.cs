using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

	private LineRenderer lineRenderer;
	private float counter;
	private float dist;

	public Transform origin;
	public Transform destination;

	public float lineDrawSpeed = 6f;

	// Use this for initialization
	void Start () 
	{

		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetPosition (1, origin.position);
		lineRenderer.SetWidth (10f, 10f);

		dist = Vector3.Distance (origin.position,destination.position);
	}
	
	// Update is called once per frame
	void Update () {

		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetPosition (0, origin.position);
		lineRenderer.SetWidth (10f, 10f);

		dist = Vector3.Distance (origin.position,destination.position);

		if (counter < dist) 
		{
			counter += 10f / lineDrawSpeed;

			float x = Mathf.Lerp (0, dist, counter);

			Vector3 pointA = origin.position;
			Vector3 pointC = destination.position;

			Vector3 pointAlongeLine = x * Vector3.Normalize (pointC - pointA) + pointA;

			lineRenderer.SetPosition (1, pointAlongeLine);
		}

	}
}
