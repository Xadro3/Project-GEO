using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject dontDestroy;
    public List<GameObject> minigame_Buttons;
    public GameObject m1_gold;
    public GameObject m1_silver; 
    public GameObject m1_bronze;
    public GameObject m2_gold;
    public GameObject m2_silver;
    public GameObject m2_bronze;
    public GameObject m3_gold;
    public GameObject m3_silver;
    public GameObject m3_bronze;
    public GameObject m4_gold;
    public GameObject m4_silver;
    public GameObject m4_bronze;
    public GameObject m5_gold;
    public GameObject m5_silver; 
    public GameObject m5_bronze;
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

        Debug.Log(dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Count);

        if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Count >= 1)
        {
            minigame_Buttons[0].SetActive(false);
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[0] == 1)
            {
                m1_gold.gameObject.SetActive(true);
            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[0] == 2)
            {
                m1_silver.gameObject.SetActive(true);

            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[0] == 3)
            {
                m1_bronze.gameObject.SetActive(true);
            }
        }

        if(dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Count >= 2)
        {
            minigame_Buttons[1].SetActive(false);
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[1] == 1)
            {
                m2_gold.gameObject.SetActive(true);
            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[1] == 2)
            {
                m2_silver.gameObject.SetActive(true);

            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[1] == 3)
            {
                m2_bronze.gameObject.SetActive(true);
            }
        }

        if(dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Count >= 3)
        {
            minigame_Buttons[2].SetActive(false);
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[2] == 1)
            {
                m3_gold.gameObject.SetActive(true);
            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[2] == 2)
            {
                m3_silver.gameObject.SetActive(true);

            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[2] == 3)
            {
                m3_bronze.gameObject.SetActive(true);
            }
        }
        
        if(dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Count >= 4)
        {
            minigame_Buttons[3].SetActive(false);
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[3] == 1)
            {
                m4_gold.gameObject.SetActive(true);
            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[3] == 2)
            {
                m4_silver.gameObject.SetActive(true);

            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[3] == 3)
            {
                m4_bronze.gameObject.SetActive(true);
            }
        }   

        if(dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Count >= 5)
        {
            minigame_Buttons[4].SetActive(false);
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[4] == 1)
            {
                m5_gold.gameObject.SetActive(true);
            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[4] == 2)
            {
                m5_silver.gameObject.SetActive(true);

            }
            if (dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls[4] == 3)
            {
                m5_bronze.gameObject.SetActive(true);
            }
        }
       


    }

    // Update is called once p
}
