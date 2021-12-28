using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharakterDontDestroy : MonoBehaviour
{
    //// Start is called before the first frame update
    //public string objectID;
    //private void Awake()
    //{
    //    objectID = name + transform.position.ToString();
    //}
    //void Start()
    //{

    //    for (int i = 0; i < Object.FindObjectsOfType<CharakterDontDestroy>().Length; i++)
    //    {
    //        if (Object.FindObjectsOfType<CharakterDontDestroy>()[i] != this)
    //        {
    //            if (Object.FindObjectsOfType<CharakterDontDestroy>()[i].objectID == objectID)
    //            {
    //                Destroy(gameObject);
    //            }
    //        }
    //    }
    //    DontDestroyOnLoad(this.gameObject);
    //}

    private static CharakterDontDestroy instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
