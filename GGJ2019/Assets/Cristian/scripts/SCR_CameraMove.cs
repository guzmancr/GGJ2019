using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_CameraMove : MonoBehaviour {


    private LayerMask Player;

    public float MoveMod = 1f;
    public float MoveCam = 5f;

    public GameObject CameraObject;
    private float xStartVal;
	// Use this for initialization
	void Start () {
        xStartVal = CameraObject.transform.position.x;

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.layer == Player)
        {

           // CameraObject.GetComponent<Rigidbody2D>.velocity = transform.right * MoveCam;
           // CameraObject.transform.GetComponent<Vector2> =
            //    =  new Vector2(transform.position.x + (MoveCam + MoveCam), 0);



        }
    }
}
