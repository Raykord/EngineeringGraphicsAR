using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideObjects : MonoBehaviour
{
    private Button button;
    public GameObject shownObject;
    public GameObject hidedObject1;
    public GameObject hidedObject2;
    public GameObject hidedObject3;
    
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(HideObjectsFunction);
    }

    void HideObjectsFunction()
	{
        hidedObject1.SetActive(false);
        hidedObject2.SetActive(false);
        hidedObject3.SetActive(false);
        shownObject.SetActive(true);
    }
}
