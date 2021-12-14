using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharakterCreationV3 : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Kopf;
    [SerializeField] private SpriteRenderer Körper;

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

    [SerializeField] private Texture[] head;
    [SerializeField] private Texture[] body;

    public void SelectHead(bool isForward)
    {
        if (isForward)
        {
            if(headID == head.Length - 1)
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
    public void SelectColorHead(bool isForward)
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
            if (headColorID == 0)
            {
                headColorID = colors.Count - 1;
            }
            else
            {
                headColorID--;
            }
        }
    }
    public void SelectColorBody(bool isForward)
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
            if (bodyColorID == 0)
            {
                bodyColorID = colors.Count - 1;
            }
            else
            {
                bodyColorID--;
            }
        }
    }

    //    private void SetItem(string type)
    //    {
    //        switch(type)
    //        {
    //            case "head":
    //                kopf.materials[0].SetSprite("Sprites-Default", head[headID]);
    //                break;
    //            case "body":
    //                break;
    //            case "headColor":
    //                break;
    //            case "bodyColor":
    //                break;
    //        }
    //    }
}

