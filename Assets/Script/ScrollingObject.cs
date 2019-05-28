using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

    public Rigidbody2D rgd;

	// Use this for initialization
	void Start ()
    {
        rgd = GetComponent<Rigidbody2D>();
        rgd.velocity = new Vector2(GameController.instance.Velocity, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(GameController.instance.isDead == true)
        {
            rgd.velocity = Vector2.zero;
        }
	}
}
