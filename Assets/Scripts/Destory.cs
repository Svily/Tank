using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
        Invoke("DestroyExplosion", 1.5f);

	}
	

    public void DestroyExplosion()
    {
        GameObject.Destroy(this.gameObject);
    }
}
