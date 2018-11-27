using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharingenRotation : MonoBehaviour {

    public GameObject ball;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        //var plane = new Plane(gameObject.transform.position.normalized, 10);

        transform.Rotate(transform.up * Time.deltaTime * 1000, Space.World);

        transform.RotateAround(ball.transform.position, transform.up, Time.deltaTime * 250);
		
	}
}
