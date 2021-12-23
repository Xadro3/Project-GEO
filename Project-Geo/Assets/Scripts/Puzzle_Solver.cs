using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Solver : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> pieces;
    public List<GameObject> solved_pieces;
    public GameObject nextButton;
    public GameObject dontDestroy;
    public int errors;

    // Update is called once per frame
    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroyOnLoad");
    }
    public void CheckSolved()
    {
        foreach(GameObject gameObject in pieces)
        {
            if (gameObject.GetComponent<Drag>().solved)
            {
                solved_pieces.Add(gameObject);
            }
        }
        if (pieces.Count==solved_pieces.Count)
        {
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games.Add(true);
            nextButton.SetActive(true);
        }
        else
        {
            Debug.Log("Niet Correkt");
            errors += 1;
            Debug.Log(errors);
            solved_pieces.Clear();
        }
    }
}
