using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_control : MonoBehaviour {

    float movrate = 5f;
    float dir_x = 0;
    float dir_z = 0;

    /*
	// Use this for initialization
	void Start ()
    {
		
	}
	*/

	// Update is called once per frame
	void Update ()
    {
        dir_x = Input.GetAxis("Horizontal");
        dir_z = Input.GetAxis("Vertical");

        this.transform.Translate(Vector3.forward * movrate * dir_z * Time.deltaTime);
        this.transform.Translate(Vector3.right * movrate * dir_x * Time.deltaTime);
	}
}
