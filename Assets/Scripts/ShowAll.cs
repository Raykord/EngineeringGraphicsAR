using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAll : MonoBehaviour
{
    private Button button;
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ShowAllObjectsFunction);
    }

    void ShowAllObjectsFunction()
    {
        Object1.SetActive(true);
        Object2.SetActive(true);
        Object3.SetActive(true);
        Object4.SetActive(true);
    }
}
