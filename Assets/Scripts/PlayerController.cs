using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D player;
    private float launchAngle = 45;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called for physics stuff
	void FixedUpdate () {
	}

    public void Launch()
    {
        

        Debug.Log("launchAngle (rad)== " + launchAngle);
        Debug.Log("launchAngle (deg)== " + (launchAngle * Mathf.PI / 180));

        launchAngle = launchAngle * Mathf.PI / 180;
        //player.AddForce(new Vector2(30, 30) * speed);
        float xSpeed = Mathf.Cos(launchAngle) * 50;
        float ySpeed = Mathf.Sin(launchAngle) * 50;

        Debug.Log("xSpeed == " + xSpeed);
        Debug.Log("ySpeed == " + ySpeed);


        player.AddForce(new Vector2(xSpeed, ySpeed));
    }

    //void OnCollisionStay2D(Collision2D coll)
    //{
    //    if(coll.gameObject.CompareTag("Wall"))
    //    {
    //        FlipVector();
    //    }
    //}

    // Launch angle is set by the slider UI
    public void SetLaunchAngle(float sliderAngle)
    {
        launchAngle = sliderAngle;
        Debug.Log("LaunchAngle == " + launchAngle);
    }

}
