﻿using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {

	public Transform myTarget;
	
	// Update is called once per frame
	void Update () {
		if (myTarget != null) {
			Vector3 targPos = myTarget.position;
			targPos.z = transform.position.z;

			// Consider using Vector3.Lerp for neat effects
			transform.position = targPos;
		}
	}
}
