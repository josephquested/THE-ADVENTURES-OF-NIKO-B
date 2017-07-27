using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrigger : MonoBehaviour {

	// GROUNDED //

	public bool grounded;
	bool _grounded;

	void OnTriggerExit2D (Collider2D collision)
	{
		if (collision.gameObject.layer == 8 && grounded) grounded = false;
	}

	void OnTriggerStay2D (Collider2D collision)
	{
		if (collision.gameObject.layer == 8 && !grounded) grounded = true;
	}

	void OnTriggerEnter2D (Collider2D collision)
	{
		if (collision.gameObject.layer == 8 && !grounded) grounded = true;
	}
// 	float distToGround;
//
// void Start(){
// 	// get the distance to ground
// 	distToGround = GetComponent<Collider2D>().bounds.extents.y;
// }
//
// public bool IsGrounded () {
// 	return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1);
// }

// function Update () {
// 	if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()){
// 		rigidbody.velocity.y = jumpSpeed;
// 	}
// }
}
