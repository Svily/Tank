using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{

    public GameObject shellExplosion;

    public AudioClip shellExplosionSound;

	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update () {
		
	}

    public void OnTriggerEnter(Collider coll)
    {
        GameObject.Instantiate(shellExplosion, this.transform.position, this.transform.rotation);
        AudioSource.PlayClipAtPoint(shellExplosionSound,transform.position);

        if (coll.tag == "Tank")
        {
            coll.SendMessage("Demage",SendMessageOptions.DontRequireReceiver);
        }

        GameObject.Destroy(this.gameObject);

    }
}
