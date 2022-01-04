using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_Charakter : MonoBehaviour
{

    public GameObject charakter;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if(go.name == "Charakter")
            {
                charakter = go;
            }
        }

    }

    public void Activator()
    {
        charakter.gameObject.SetActive(true);
    }

    public void Deactivator()
    {
        charakter.gameObject.SetActive(false);
    }
}
