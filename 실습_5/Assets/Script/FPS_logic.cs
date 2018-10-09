using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_logic : MonoBehaviour {

    float deltatime = 0.0f;
    float fps = 0;
    float cnt = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        cnt++;
        deltatime += Time.deltaTime;
        if(deltatime >= 1f)
        {
            fps = cnt;
            deltatime = 0;
            print(fps);
            cnt = 0;
        }
	}
}
