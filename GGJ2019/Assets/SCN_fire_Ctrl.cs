using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCN_fire_Ctrl : MonoBehaviour {
    public GameObject Particle_R_1;
    public GameObject Particle_R_2;

    public GameObject Particle_L_1;
    public GameObject Particle_L_2;

    private ParticleSystem ps1;
    private ParticleSystem ps2;

    private ParticleSystem psLast;

    private float moveValue;
    // Use this for initialization
    void Start () {
        moveValue = 1;

        ps1 = Particle_R_1.GetComponent<ParticleSystem>();
        ps2 = Particle_R_2.GetComponent<ParticleSystem>();

        //psLast = Particle_L_1.GetComponent<ParticleSystem>();

        ps1.Play(true);
        ps2.Play(true);
    }
	
	// Update is called once per frame
	void Update () {

     //   moveValue = Input.

       // if (moveValue > 0 )//&& psLast.isPlaying == true)
       // {
//turnFireOn(Particle_R_1, Particle_R_2);

       // } else if (moveValue < 0 )//&& psLast.isPlaying == true)
       // {
       //     turnFireOn(Particle_L_1, Particle_L_2);
      //  }


	}


    void turnFireOn(GameObject Fire1, GameObject Fire2)
    {
        ps1.Play(false);
        ps2.Play(false);

        ps1 = Fire1.GetComponent<ParticleSystem>();
        ps2 = Fire2.GetComponent<ParticleSystem>();

        ps1.Play(true);
        ps2.Play(true);

    }
}
