using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class slider : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    bool te = false;
    public GameObject left, tleft, bleft, right, tright, bright;
    int a = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (te)
        {

            left.transform.Translate(0.0005f, 0, -0.0005f);
            tleft.transform.Translate(0.0005f, -0.0005f, -0.0005f);
            bleft.transform.Translate(0.0005f, 0.0005f, -0.0005f);
            right.transform.Translate(-0.0005f, 0, -0.0005f);
            tright.transform.Translate(-0.0005f, -0.0005f, -0.0005f);
            bright.transform.Translate(-0.0005f, 0.0005f, -0.0005f);

        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        te = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        te = false;
    }
}
