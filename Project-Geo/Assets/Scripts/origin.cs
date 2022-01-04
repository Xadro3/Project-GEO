using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class origin : MonoBehaviour
{
    Vector3 originPos;
    public delegate void DragEndedDelegate(Drag objects);
    public DragEndedDelegate dragEndedCallback;

    private Vector3 dragoffset;
    private Camera cam;
    public bool dragging;
    public bool solved;
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        originPos= gameObject.transform.position;
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        dragoffset = transform.position - GetMousePos();
        dragging = true;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + dragoffset;
    }
    private void OnMouseUp()
    {
        transform.position = originPos;
        dragging = false;
        gameObject.GetComponent<Colorizer>().colorize();
    }
    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
    private void Update()
    {
        if (!dragging)
        {
            transform.position = originPos;
        }
    }



}


