using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;
			
	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;

		if (Input.GetButtonDown ("Fire1") && cooldownTimer <= 0) {
			cooldownTimer = fireDelay;
			print("Shoot!");
		}
	}
}
