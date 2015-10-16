﻿using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	public enum Direction { Up, Down, Left, Right }
	public Direction direction;

	void Start () {
	}
	
	void Update () {
	}

	public void SetColor(Color col) {
		GetComponent<SpriteRenderer> ().color = col;
	}

	public void SetDirection(Direction dir) {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		direction = dir;
		switch (dir) {
		case Direction.Up:
			rb.velocity = new Vector2(0, 2);
			break;
		case Direction.Down:
			rb.velocity = new Vector2(0, -2);
			break;
		case Direction.Left:
			rb.velocity = new Vector2(-2, 0);
			break;
		case Direction.Right:
			rb.velocity = new Vector2(2, 0);
			break;
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		// Stick them.
		HingeJoint2D myJoint = (HingeJoint2D)gameObject.AddComponent<HingeJoint2D>();
		myJoint.connectedBody = other.rigidbody;
	}
	
}
