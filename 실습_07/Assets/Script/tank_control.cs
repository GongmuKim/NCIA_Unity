using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_control : MonoBehaviour {

    float moverate = 8f;
    float rotate = 110;
    float turret_rotate = 2;
    float barrel_rotate = 1;
    public GameObject turret;
    public GameObject barrel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float movval = moverate * Time.deltaTime;
        float rotval = rotate * Time.deltaTime;
        float mov_dir = Input.GetAxis("Vertical");
        float rot_dir = Input.GetAxis("Horizontal");

        this.transform.Translate(Vector3.forward * mov_dir * movval);
        this.transform.Rotate(0, rot_dir * rotval, 0);
        //this.transform.Rotate(Vector3.up * rot_dir * rotval);
        float turret_rot_dir = Input.GetAxis("turret_rotate");
        turret.transform.Rotate(Vector3.up * turret_rotate * turret_rot_dir);

        float barrel_rot_dir = Input.GetAxis("turret_Scroll");
        //대상
        barrel.transform.Rotate(Vector3.right * barrel_rotate * barrel_rot_dir);

	}
}
