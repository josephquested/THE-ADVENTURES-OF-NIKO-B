using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niko : MonoBehaviour {

	Rigidbody2D rb;

	public float jumpForce;
	public GroundTrigger gt;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	void Update ()
	{
		UpdateAnimator();
		UpdateJump();
	}

	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapArea(top_left.position, bottom_right.position, ground_layers);
	}

	void UpdateJump ()
	{
		if (Input.GetButtonDown("Jump") && grounded)
		{
			Jump();
		}
	}

	void Jump ()
	{
		rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
	}

	// ANIMATOR //

	Animator anim;

	void UpdateAnimator ()
	{
		anim.SetBool("Grounded", grounded);
	}

	// GROUNDED //

	public Transform top_left;
	public Transform bottom_right;
	public LayerMask ground_layers;
	public bool grounded;

}
