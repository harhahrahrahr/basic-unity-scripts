// Movement on the X and Z axis

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed;
	private float x, y;
	void Update() {
		x = Input.GetAxisRaw("Horizontal");
		y = Input.GetAxisRaw("Vertical");
		transform.Translate(speed * x * Time.deltaTime, 0f, speed * y * Time.deltaTime);
	}
}