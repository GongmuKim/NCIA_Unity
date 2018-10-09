using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_control : MonoBehaviour {

    float move_rate = 5f;
    float dir_x = 0;
    float dir_z = 0;
    /*
	// Use this for initialization
	void Start () {
		
	}
	*/

    // Update is called once per frame
    void Update()
    {
        dir_x = Input.GetAxis("Horizontal");
        dir_z = Input.GetAxis("Vertical");

        this.transform.Translate(Vector3.forward * move_rate * dir_z * Time.deltaTime);
        this.transform.Translate(Vector3.right * move_rate * dir_x * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 충돌시작\n");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("트리거 충돌체 머무는중\n");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("트리거 충돌 빠져나옴");        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("콜라이더 충돌시작\n");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("콜라이더 충돌체 머무는중\n");
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("콜라이더 충돌 빠져나옴");
    }
}
