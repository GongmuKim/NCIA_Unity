using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_control : MonoBehaviour {

    public Text info_data;
    int num = 19960201;
    string temp = "";


	// Use this for initialization
	void Start ()
    {
        info_data.text = num.ToString();
        info_data.text = "" + num;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Click_act()
    {
        temp = "버튼이 눌렸다!";
    }
}
