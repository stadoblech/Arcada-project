﻿using UnityEngine;
using System.Collections;

public class EnemyLife : MonoBehaviour {

    public float shield;
    public float lives;
    public bool destroyObjectOnNoHp;
    public bool destroyParent;

    public bool living;
	void Start () {
        living = true;
	}
	
	void Update () {
	    if(lives <= 0)
        {
            if (destroyObjectOnNoHp)
            {
                Destroy(gameObject);
            }
            else if (!destroyObjectOnNoHp && !destroyParent)
            {
                living = false;
            }else if(destroyParent)
            {
                Destroy(transform.parent.gameObject);
            }
            
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "PlayerShot")
        {
            Destroy(coll.gameObject);

            if (shield > 0)
            {
                shield -= coll.gameObject.GetComponent<ShotDamage>().damage;
            }
            else
            {
                lives -= coll.gameObject.GetComponent<ShotDamage>().damage;
            }
        }

        if(coll.tag == "Player")
        {
            coll.GetComponent<PlayerLife>().getHit(lives);
            lives = 0;
            //coll.gameObject.GetComponent<PlayerLife>().
            /// kdzy se stretne player s enemy
        }
    }
}
