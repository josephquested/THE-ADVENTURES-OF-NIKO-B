﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideLeft : MonoBehaviour {

	public float speed;

	void FixedUpdate ()
	{
		transform.Translate(Vector2.left * speed / 10);
	}
}