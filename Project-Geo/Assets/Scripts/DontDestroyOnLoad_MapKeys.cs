using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad_MapKeys : MonoBehaviour
{
    // Start is called before the first frame update
    public List<bool> solved_games;
    private static DontDestroyOnLoad_MapKeys dontDestroyinstance;
    void Start()
    {
       
        DontDestroyOnLoad(this.gameObject);
        if(dontDestroyinstance == null)
        {
            dontDestroyinstance = this;
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }




}


