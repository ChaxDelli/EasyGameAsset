﻿using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	public float speed = 0.5F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = Vector3.zero;
		//dir.x = -Input.acceleration.y;
		dir.z = Input.acceleration.x;
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		dir *= Time.deltaTime;
		transform.Translate(dir * speed);
	}
}