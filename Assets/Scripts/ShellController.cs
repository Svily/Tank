using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{

    private Transform firePointTransform;

    public GameObject shell;

    public KeyCode fireKeyCode = KeyCode.Space;

    public float shellSpeed = 20f;

    public AudioClip shootShellSound;

	// Use this for initialization
	void Start ()
	{

	    firePointTransform = transform.Find("FirePoint");

	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetKeyDown(fireKeyCode))
	    {
           AudioSource.PlayClipAtPoint(shootShellSound,transform.position);
	       GameObject go = GameObject.Instantiate(shell,firePointTransform.position,firePointTransform.rotation);
	       go.GetComponent<Rigidbody>().velocity = transform.forward * shellSpeed;
	    }

	}
}
