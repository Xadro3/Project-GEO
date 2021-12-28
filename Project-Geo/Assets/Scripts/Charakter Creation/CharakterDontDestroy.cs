using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharakterDontDestroy : MonoBehaviour
{

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
