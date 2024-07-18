using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;

    public void Opent2()
    {
        t2.SetActive(true);
        t1.SetActive(false);
    }
    public void Opent3()
    {
        t3.SetActive(true);
        t2.SetActive(false);
    }
    public void Opent4()
    {
        t4.SetActive(true);
        t3.SetActive(false);
    }
}