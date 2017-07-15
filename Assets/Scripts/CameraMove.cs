﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = transform.eulerAngles;
		rotation += new Vector3(-3*Input.GetAxis("Mouse Y"), 3*Input.GetAxis("Mouse X"),  0);
//		rotation.x = Mathf.Clamp (rotation.x, 270, 40);
//		rotation.y = Mathf.Clamp (rotation.y, -40, 40);
		transform.eulerAngles = rotation;
	}
}