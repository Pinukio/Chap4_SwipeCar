using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI�� ����ϴ� �� �ʿ���.

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    Text t;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
        this.t = this.distance.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if(length < 0)
        {
            t.text = "���� ����!!!!!";
        }
        
        else
        {
            t.text = "��ǥ ��������" + length.ToString("F2") + "m";
        }
    }
}
