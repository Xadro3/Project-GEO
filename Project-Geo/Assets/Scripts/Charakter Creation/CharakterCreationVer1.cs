using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class CharakterCreationVer1 : MonoBehaviour
{
    public SpriteRenderer headrend;
    public Image kopf;
    public SpriteRenderer bodyrend;
    public Image k�rper;

    //private Dictionary<string, string> colors =
    //    new Dictionary<string, string>()
    //    {
    //        {"Rot", "#E74C3C" },
    //        {"orange", "#E78A3C" },
    //        {"Gelb", "#FFFF00" }
    //    };

    private int headID;
    private int headColorID = 1;
    private int bodyID;
    public int bodyColorID = 1;

    public Color[] coloris;

    [SerializeField] private Sprite[] head;
    [SerializeField] private Sprite[] body;

    //private void Awake()
    //{
    //    headID = PlayerPrefs.GetInt("head", 0);
    //    bodyID = PlayerPrefs.GetInt("body", 0);
    //    headColorID = PlayerPrefs.GetInt("headColor", 0);
    //    bodyColorID = PlayerPrefs.GetInt("bodyColor", 0);
    //}

    //private void Start()
    //{
    //    SetItem("head");
    //    SetItem("body");
    //    SetItem("headColor");
    //    SetItem("bodyColor");
    //}

    void Update()
    {
        for (int i = 0; i < head.Length; i++)
        {
            if (i == headID)
            {
                headrend.sprite = head[i];
            }
        }
        for (int i = 0; i < body.Length; i++)
        {
            if (i == bodyID)
            {
                bodyrend.sprite = body[i];
            }
        }

        k�rper.color = bodyrend.color;

        for (int i = 0; i < coloris.Length; i++)
        {
            if (i == bodyColorID)
            {
                bodyrend.color = coloris[i];
            }
        }

    }

    public void SelectHead(bool isForward)
    {
        if (isForward)
        {
            if (headID == head.Length - 1)
            {
                headID = 0;
            }
            else
            {
                headID++;
            }
        }
        else
        {
            if (headID == 0)
            {
                headID = head.Length - 1;
            }
            else
            {
                headID--;
            }
        }
    }
    
    public void SelectBody(bool isForward)
    {
        if (isForward)
        {
            if (bodyID == body.Length - 1)
            {
                bodyID = 0;
            }
            else
            {
                bodyID++;
            }
        }
        else
        {
            if (bodyID == 0)
            {
                bodyID = body.Length - 1;
            }
            else
            {
                bodyID--;
            }
        }
    }
    
    public void SelectBodyColor(bool isForward)
    {
        if (isForward)
        {
            if (bodyColorID == coloris.Length - 1)
            {
                bodyColorID = 0;
            }
            else
            {
                bodyColorID++;
            }
        }
        else
        {
            if (bodyColorID == 0)
            {
                bodyColorID = coloris.Length - 1;
            }
            else
            {
                bodyColorID--;
            }
        }
    }

    public void SelectHeadColor(bool isForward)
    {
        if (isForward)
        {
            if (headColorID == coloris.Length - 1)
            {
                headColorID = 0;
            }
            else
            {
                headColorID++;
            }
        }
        else
        {
            if (headColorID == 0)
            {
                headColorID = coloris.Length - 1;
            }
            else
            {
                headColorID--;
            }
        }
    }
}