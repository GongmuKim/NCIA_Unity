using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clicker_logic : MonoBehaviour {
    /*
     Coin_text; // 0
     Place_text; // 1
     Message_box_text; // 2
     Finish_Message_box_text; // 3
    */

    public Text[] text_line = new Text[4];
    /*
    Garage_img;   // 0
    Office_img;   // 1
    NCoffice_img; // 2
    Message_box;  // 3
    Finish_Message_box // 4
    */
    public GameObject[] gameobjects_line = new GameObject[7];

    private long amount_money = 0;
    private long final_score = 10000000000;
    private int money_click_earn = 0;
    private int Tech_up_level = 1;
    private int Tech_up_cost = 100;
    private int Manpower_up_level = 1;
    private int Manpower_up_cost = 50;
    private int Office_level = 1;
    private int Office_up_cost = 10000;
    private bool flag_final_message = false;

	// Use this for initialization
	void Start ()
    {
        text_line[1].text = "";
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(text_line[1].text == "")
        {
            text_line[1].text = "Garage";
            gameobjects_line[0].SetActive(true);
        }
        else if(Office_level == 2)
        {
            text_line[1].text = "Office";
            gameobjects_line[0].SetActive(false);
            gameobjects_line[1].SetActive(true);
        }
        else if(Office_level == 3)
        {
            text_line[1].text = "NC Soft";
            gameobjects_line[1].SetActive(false);
            gameobjects_line[2].SetActive(true);
            gameobjects_line[6].SetActive(false);
            if(flag_final_message == false)
            {
                print("최종미션 발동");
                Final_goal();
                flag_final_message = true;
            }
        }

        if(amount_money >= final_score)
        {
            text_line[3].text = "축하합니다!\n당신은 NC소프트 CEO 입니다!";
            gameobjects_line[4].SetActive(true);
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            gameobjects_line[5].SetActive(true);
        }
	}

    public void Click_Money()
    {
        money_click_earn += Tech_up_level;
        money_click_earn += Manpower_up_level;
        money_click_earn += Office_level;
        amount_money += money_click_earn;
        text_line[0].text = amount_money.ToString();
    }

    public void Click_TechUp()
    {
        if(amount_money >= Tech_up_cost)
        {
            print("테크 업그레이드!");
            amount_money -= Tech_up_cost;
            text_line[0].text = amount_money.ToString();
            Tech_up_level++;
            Tech_up_cost *= 250;
        }
        else
        {
            text_line[2].text = "잔액부족 : " + (Tech_up_cost - amount_money);
            gameobjects_line[3].SetActive(true);
        }
    }

    public void Click_ManpowerUp()
    {
        if (amount_money >= Manpower_up_cost)
        {
            print("인력 추가!");
            amount_money -= Manpower_up_cost;
            text_line[0].text = amount_money.ToString();
            Manpower_up_level++;
            Manpower_up_cost *= 50;
        }
        else
        {
            text_line[2].text = "잔액부족 : " + (Manpower_up_cost - amount_money);
            gameobjects_line[3].SetActive(true);
        }
    }

    public void Click_Office_upgrade()
    {
        print("현재 보유 돈 : " + amount_money);
        print("사무실 비용 : " + Office_up_cost);
        if (amount_money >= Office_up_cost)
        {
            print("사무실 업그레이드!");
            amount_money -= Office_up_cost;
            text_line[0].text = amount_money.ToString();
            Office_level++;
            Office_up_cost *= 500;

        }
        else
        {
            print("Tech_up 실패!");
            text_line[2].text = "잔액부족 : " + (Office_up_cost - amount_money);
            gameobjects_line[3].SetActive(true);
        }
    }

    public void Final_goal()
    {
        text_line[2].text = "목표 : 100억 만들기";
        gameobjects_line[3].SetActive(true);
    }

    public void Click_MessageBox()
    {
        print("메세지창 닫기");
        gameobjects_line[3].SetActive(false);
    }

    public void Click_Restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void Click_Exit()
    {
        SceneManager.LoadScene("Start");
    }
}
