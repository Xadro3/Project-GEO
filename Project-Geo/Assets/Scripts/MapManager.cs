using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject dontDestroy;
    public List<GameObject> minigame_Buttons;
    void Start()
    {
        dontDestroy = GameObject.Find("DontDestroyOnLoad");
        for(int i=0;i< dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games.Count; i++)
        {
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games[i])
            {
                minigame_Buttons[i].SetActive(true);
            }
        }
    }

    // Update is called once p
}
