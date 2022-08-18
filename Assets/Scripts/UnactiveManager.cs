using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnactiveManager : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;

    void Start()
    {
        Object1.SetActive(false);
        Object2.SetActive(false);
        Object3.SetActive(false);
    }

}
