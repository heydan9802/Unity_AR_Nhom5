using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float ZoonChange;
    public float SmoothChange;
    public float Min, Max;
    private Camera cam;
    // Start is called before the first frame update
    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    private void Update()
    {
       if (Input.mouseScrollDelta.y >0)
            cam.orthographicSize -= ZoonChange * Time.deltaTime * SmoothChange;
       if (Input.mouseScrollDelta.y < 0)
            cam.orthographicSize += ZoonChange * Time.deltaTime * SmoothChange;

        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, Min, Max);
    }
}
