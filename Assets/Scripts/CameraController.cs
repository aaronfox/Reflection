using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is last. Needed to make sure offset is calculated first
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
