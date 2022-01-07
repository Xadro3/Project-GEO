using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpecialSolver : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Fungus.Flowchart myFlow;
    public List<GameObject> pieces;
    public List<GameObject> solved_pieces;
    public GameObject nextButton;
    
    public GameObject dontDestroy;
  
  
    public int errors;
    public double timeElapsed;
    public Vector3 targetPosition = new Vector3(0, 8, 0);
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroyOnLoad");
    }
    public void CheckSolved()
    {
        foreach (GameObject gameObject in pieces)
        {
            Debug.Log(gameObject.name);
            if (gameObject.GetComponent<Drag>().solved)
            {
                solved_pieces.Add(gameObject);
            }
        }
        if (pieces.Count == solved_pieces.Count)
        {

            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().errorsMinigame3_1 = errors;
            end();
        }
        else
        {
            Debug.Log("Niet Correkt");
            errors += 1;
            Debug.Log(errors);
            solved_pieces.Clear();
            myFlow.ExecuteBlock("help");
        }

    }
    public void end()
    {
        
            nextButton.gameObject.SetActive(true);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().timeMinigame3_1 = Time.timeSinceLevelLoadAsDouble;
        
    }

  
}
