using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
public float fastmove;
	void Start () {
			
	}
	
	void Update () {
		Rigidbody2D rididbody = GetComponent<Rigidbody2D>();	
		//movimento_horizontal
			float move = Input.GetAxis("Horizontal");
			rididbody.velocity = new Vector2(move*fastmove,rididbody.velocity.y);	
		//jump
			if(Input.GetKeyDown(KeyCode.Space))
			{rididbody.AddForce(new Vector2(0,200));}
}}
