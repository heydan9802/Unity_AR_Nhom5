using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickbutton : MonoBehaviour
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
        text.GetComponent<Text>().text = "Nap code vao raspberry";
        Debug.Log("hello world");
    }    
}
