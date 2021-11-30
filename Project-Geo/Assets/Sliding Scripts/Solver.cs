using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solver : MonoBehaviour
{
    [SerializeField]
    GameObject[] slider;
    [SerializeField]
    bool[] correctpieces;
    int solved = 0;
    [SerializeField]
    GameObject missing;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < slider.Length; i++)
        {
            Debug.Log(i);
            correctpieces[i] = slider[i].gameObject.GetComponent<Slider>().solved;
        }

        for (int i = 0; i < correctpieces.Length; i++)
        {
            if (correctpieces[i])
            {
                solved++;
            }
        }
        if (solved == correctpieces.Length)
        {
            missing.SetActive(true);


        }
        else
        {
            solved = 0;
        }

    }
}
