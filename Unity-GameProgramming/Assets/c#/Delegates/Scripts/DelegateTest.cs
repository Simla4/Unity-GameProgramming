using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void TestDelegate(); //Tanımlama
    public TestDelegate testDelegate; //Objesini oluşturduk
    //delegate ve içine atayacağımız fonkisyonun tipi aynı olmalıdır

    void Start()
    {
        testDelegate += Debug1;//iki fonsiyonu aynı anda çağırabilioruz
        testDelegate += Debug2;
        testDelegate();
    }

    private void Debug1()
    {
        Debug.Log("Debug1");
    }

    private void Debug2()
    {
        Debug.Log("Debug2");
    }
}
