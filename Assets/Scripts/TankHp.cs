using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHp : MonoBehaviour
{

    public int hp = 100;

    public GameObject tankExplosion;

    public AudioClip tankExplosionSound;

    public int totalHp;

    public Slider HpSlider;

	void Start ()
	{

	    totalHp = hp;
	    HpSlider.value = 1;


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Demage()

    {
        if (hp <=0)
        {
            
            return;
        }

        hp -= Random.Range(10, 20);
        HpSlider.value = (float) hp / totalHp;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(tankExplosionSound,transform.position);
            GameObject.Instantiate(tankExplosion,this.transform.position+Vector3.up,this.transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
