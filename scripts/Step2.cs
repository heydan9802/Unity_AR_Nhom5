using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step2 : MonoBehaviour
{ 
    // Start is called before the first frame update
    public GameObject text;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Hello()
    {
        text.GetComponent<Text>().text = "Ket noi micro voi USB sound card sau do ket noi vs raspberry";
        Debug.Log("hello world");
    }
}
