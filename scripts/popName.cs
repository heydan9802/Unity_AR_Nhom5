using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popName : MonoBehaviour
{
    private Text label;

    void Start()
    {
        label = GameObject.Find("LabelName").GetComponent<Text>();
        label.text = "";
    }
    private void OnMouseDown()
    {
        label.text = gameObject.name.ToString();
    }

}

