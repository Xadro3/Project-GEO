using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharakterCreationVer1 : MonoBehaviour
{
    public SpriteRenderer headrend;

    private Dictionary<string, string> colors =
        new Dictionary<string, string>()
        {
            {"Rot", "#E74C3C" },
            {"orange", "#E78A3C" },
            {"Gelb", "#FFFF00" }
        };

    private int headID;
    private int headColorID;
    private int bodyID;
    private int bodyColorID;

    [SerializeField] private Sprite[] head;
    [SerializeField] private Sprite[] body;

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
            headID--;
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
            bodyID--;
        }
    }

    public void SelectBodyColor(bool isForward)
    {
        if (isForward)
        {
            if (bodyColorID == colors.Count - 1)
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
            bodyColorID--;
        }
    }

    public void SelectHeadColor(bool isForward)
    {
        if (isForward)
        {
            if (headColorID == colors.Count - 1)
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
            headColorID--;
        }
    }
}
