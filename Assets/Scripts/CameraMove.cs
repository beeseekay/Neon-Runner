﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	float xSpeed;
	float ySpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = transform.localEulerAngles;
		rotation += new Vector3(-3*Input.GetAxis("Mouse Y"), 3*Input.GetAxis("Mouse X"),  0);
		rotation.x = Mathf.Clamp ((rotation.x > 180) ? rotation.x - 360 : rotation.x, -40, 40);
		rotation.x = Mathf.SmoothDampAngle (rotation.x, 0, ref xSpeed, 2);
		rotation.y = Mathf.Clamp ((rotation.y > 180) ? rotation.y - 360 : rotation.y, -40, 40);
		rotation.y = Mathf.SmoothDampAngle (rotation.y, 0, ref ySpeed, 2);
		transform.localEulerAngles = rotation;
	}
}
