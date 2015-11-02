using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed = 5f;
	public float rotSpeed = 180f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Rotating the ship
		// Grab rotation quaternion
		Quaternion rot = transform.rotation;

		// Grab the Z euler angle
		float z = rot.eulerAngles.z;

		// Change the Z angle based on input
		z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

		// Recreate the quaternion
		rot = Quaternion.Euler(0, 0, z);

		// feed the quaternion into rotation
		transform.rotation = rot;

		// Moving the ship
		//transform.Translate (new Vector3 (0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0));
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3(0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0);
		pos += rot * velocity;

		transform.position = pos;

	}
}
