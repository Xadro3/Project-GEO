using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorizer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Color32 color;
    Collider2D collider2D;

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collider2D = collision;
      
    }

    public void colorize()
    {
        if (collider2D.gameObject.GetComponent<colorizable>() != null)
        {
            collider2D.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
        
    }
}
