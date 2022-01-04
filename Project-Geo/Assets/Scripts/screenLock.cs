using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenLock : MonoBehaviour
{
    Vector3 originpoint;
    // Start is called before the first frame update
    void Start()
    {
        originpoint = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if(transform.position.x >6.5|| transform.position.x < -6.5)
        {
            transform.position = originpoint;
        }
        if(transform.position.y >5 || transform.position.y < -5)
        {
            transform.position = originpoint;
        }
    }
}
