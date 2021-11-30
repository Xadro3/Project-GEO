using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    // Start is called before the first frame update

    public delegate void DragEndedDelegate(Drag objects);
    public DragEndedDelegate dragEndedCallback;

    private Vector3 dragoffset;
    private Camera cam;
    public bool dragging;

    private void Awake()
    {
        cam = Camera.main;
    }
    private void OnMouseDown()
    {
        dragoffset = transform.position - GetMousePos();
        dragging = true;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos()+dragoffset;
    }
    private void OnMouseUp()
    {
        dragging = false;
        dragEndedCallback(this);
    }
    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
    
    
}
