using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D player;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called for physics stuff
	void FixedUpdate () {
        
	}

    public void Launch()
    {
        Vector2 movement = new Vector2(30, 30);
        player.AddForce(movement * speed);
    }
}
