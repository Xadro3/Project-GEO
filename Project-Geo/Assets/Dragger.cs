using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;
    SpriteRenderer renderer;

    private void Start()
    {
        renderer = GetComponent < SpriteRenderer >();
    }
    void OnMouseEnter()
    {
        Debug.Log("Mouse Ender");
        renderer.material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        renderer.material.color = originalColor;
    }

    void OnMouseDown()
    {
        Debug.Log("Mouse down");
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        Debug.Log("Mouse UP");
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Debug.Log("Mouse drag");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }

    }
}
