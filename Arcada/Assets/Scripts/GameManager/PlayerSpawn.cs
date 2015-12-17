﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSpawn : MonoBehaviour {

    Transform route;

    List<GameObject> points;

	void Start () {

        points = new List<GameObject>();

        route = GameObject.FindGameObjectWithTag("Route").transform;

        foreach(Transform point in route)
        {
            points.Add(point.gameObject);
        }

        foreach(GameObject o in points)
        {
            if(o.name == "0")
            {
                GameObject.FindGameObjectWithTag("Player").transform.position = o.transform.position;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
