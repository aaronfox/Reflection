using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D player;
    private float xDir = 0, yDir = 0;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called for physics stuff
	void FixedUpdate () {
	}

    public void Launch()
    {
        player.AddForce(new Vector2(30, 30) * speed);
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Wall"))
        {
            FlipVector();
        }
    }

    void FlipVector()
    {
        //player.transform.Rotate(new Vector)
    }
}
