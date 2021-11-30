using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject emptyPiece;
    float xposition;
    float yposition;

    public float xshould;
    public float yshould;
    public bool solved = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == xshould)
        {
            if (transform.position.y == yshould)
            {
                solved = true;
            }
            else
            {
                solved = false;
            }
        }


    }
    void OnMouseDown()
    {
        if (Vector2.Distance(transform.position, emptyPiece.transform.position) == 1)
        {
            xposition = transform.position.x;
            yposition = transform.position.y;
            transform.position = new Vector2(emptyPiece.transform.position.x, emptyPiece.transform.position.y);
            emptyPiece.transform.position = new Vector2(xposition, yposition);

        }
    }
}
