using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour {



    public GameObject ado;
    AudioSource ADD;

	// Use this for initialization
	void Start () {
        ADD = ado.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}




    private void OnTriggerEnter(Collider other)
    {
        AudioSource au = GetComponent<AudioSource>();
        au.Play();
        ADD.Stop();
    }

}
