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
    public Image körper;
    public SpriteRenderer eyerend;

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
    private int bodyColorID = 1;
    private int eyeID;

    public Color[] coloris; // Farb Feld in unity anpassbar, soll nutzbar zur asset farbwechsel sein (ists momentan nicht.)

    [SerializeField] private Sprite[] head;
    [SerializeField] private Sprite[] body;
    [SerializeField] private Sprite[] eye;

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
        for (int i = 0; i < head.Length; i++) // Kopf
        {
            if (i == headID)
            {
                headrend.sprite = head[i];
            }
        }
        
        for (int i = 0; i < body.Length; i++) // Körper
        {
            if (i == bodyID)
            {
                bodyrend.sprite = body[i];
            }
        }

        for (int i = 0; i < eye.Length; i++) // Augen
        {
            if (i == eyeID)
            {
                eyerend.sprite = eye[i];
            }
        }

        //// Für die Farbwahl, noch nicht sicher ob das noch hinhaut...
        //körper.color = bodyrend.color;

        //for (int i = 0; i < coloris.Length; i++)
        //{
        //    if (i == bodyColorID)
        //    {
        //        bodyrend.color = coloris[i];
        //    }
        //}

        //kopf.color = headrend.color;

        //for (int i = 0; i < coloris.Length; i++)
        //{
        //    if (i == headColorID)
        //    {
        //        headrend.color = coloris[i];
        //    }
        //}
        //// ...endet hier
    }

    public void SelectHead(bool isForward) // zur auswahl des Kopfes
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
    
    public void SelectBody(bool isForward)// zur auswahl des Körpers
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

    public void SelectEye(bool isForward) // zur auswahl des Kopfes
    {
        if (isForward)
        {
            if (eyeID == eye.Length - 1)
            {
                eyeID = 0;
            }
            else
            {
                eyeID++;
            }
        }
        else
        {
            if (eyeID == 0)
            {
                eyeID = eye.Length - 1;
            }
            else
            {
                eyeID--;
            }
        }
    }

    public void SelectBodyColor(bool isForward) // zur auswahl der Körperfarbe
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

    public void SelectHeadColor(bool isForward) // zur Farbauswahl für den Kopf
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