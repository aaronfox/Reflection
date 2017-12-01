using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateScript : MonoBehaviour {

    [SerializeField]
    private GameObject finalObject;

    private Vector2 mousePos;

    [SerializeField]
    private LayerMask allTilesLayer;
	
	// Update is called once per frame
	void Update () {
        // This follows the mouse around when placing object
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

        // On mosue click, place final version of object
        if (Input.GetMouseButtonDown(0))
        {
            // Create temp mouseRay to grab current position
            RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, allTilesLayer);

            // Makes sure there's not an object there already
            // NOTE: c00pala said object should be a RigidBody2D, but I'm not
            // sure the Upell prefab is right now. See https://www.youtube.com/watch?v=D9ZU0mfukQE
            if (rayHit.collider == null)
            {
                Instantiate(finalObject, transform.position, Quaternion.identity);
                Debug.Log("rayHit didn't hit anything!");
            }
            else
            {
                Debug.Log("rayHit hit something!");
            }
        }
	}
}
