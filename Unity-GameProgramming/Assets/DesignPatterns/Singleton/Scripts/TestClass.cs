using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        GameManager.Instance.Write();
    }
}
