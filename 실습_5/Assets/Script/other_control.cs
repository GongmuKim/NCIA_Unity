using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class other_control : MonoBehaviour {

    public GameObject model1;
    public Transform model2;
    float elapsedtime = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        elapsedtime += Time.deltaTime;
        if(elapsedtime >= 2f)
        {
            model2.gameObject.SetActive(true);
        }
	}
}
