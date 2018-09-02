using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    private Rigidbody rigidbody;

    public float speed = 5f;

    public float angelSpeed = 3f;

    public int player = 1;

    public AudioClip idleClip;
    public AudioClip drivingClip;

    private AudioSource audioSource;

	void Start ()
	{

	    rigidbody = this.GetComponent<Rigidbody>();

	    audioSource = this.GetComponent<AudioSource>();

        
	}

    void Update()
    {

        float v = Input.GetAxis("Vertical@player"+player);

        rigidbody.velocity = transform.forward*v*speed;

        float h = Input.GetAxis("Horizontal@player"+player);

        rigidbody.angularVelocity = transform.up *h* angelSpeed;

        if (Mathf.Abs(v)>0.1 ||Mathf.Abs(h)>0.1)
        {
            audioSource.clip = drivingClip;
            if (audioSource.isPlaying == false)
            {
                audioSource.Play();
            }
            
        }
        else
        {
            audioSource.clip = idleClip;
            if (audioSource.isPlaying == false)
            {
                audioSource.Play();
            }
        }

    }

    
}
