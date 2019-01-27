using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_SmoothCamMove : MonoBehaviour {
    public Transform target;

    public float smoothSpeed = 0.35f; 
    public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        Vector3 desiredPosition = offset + target.position;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;


	}
}
