using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpecialSolver2 : MonoBehaviour
{
    // Start is called before the first frame update
    public double minTime;
    public Fungus.Flowchart myFlow;
    public List<GameObject> pieces;
    public List<GameObject> solved_pieces;
    public GameObject nextButton;
    public Button endbutton;
    public GameObject dontDestroy;
    public GameObject resultScreen;
    public GameObject bronze;
    public GameObject silver;
    public GameObject gold;
    public int errors;
    public double timeElapsed;
    public Vector3 targetPosition = new Vector3(0, 8, 0);
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroyOnLoad");
        errors += dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().errorsMinigame3_1; 
        timeElapsed += dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().timeMinigame3_1;
    }
    public void CheckSolved()
    {
        foreach (GameObject gameObject in pieces)
        {
            if (gameObject.GetComponent<Drag>().solved)
            {
                solved_pieces.Add(gameObject);
            }
        }
        if (pieces.Count == solved_pieces.Count)
        {
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games.Add(true);
            Debug.Log(errors);
            myFlow.ExecuteBlock("correct");
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
        if (errors == 0 && Time.timeSinceLevelLoadAsDouble < minTime)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            gold.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
            StartCoroutine(move());

            endbutton.gameObject.SetActive(true);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(1);
        }
        if ((errors == 1 && Time.timeSinceLevelLoadAsDouble < minTime)|| (errors == 2 && Time.timeSinceLevelLoadAsDouble < minTime))
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            silver.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
            StartCoroutine(move());

            endbutton.gameObject.SetActive(true);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(2);
        }
        if (errors > 2 || Time.timeSinceLevelLoadAsDouble > minTime)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            Debug.Log(timeElapsed);
            bronze.gameObject.SetActive(true);
            StartCoroutine(move());

            endbutton.gameObject.SetActive(true);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(3);
        }
    }

    public void nextScene()
    {
        SceneManager.LoadScene("Worldmap");
    }
    IEnumerator move()
    {
        while (resultScreen.transform.position != targetPosition)
        {
            resultScreen.transform.position = Vector3.SmoothDamp(resultScreen.transform.position, targetPosition, ref velocity, smoothTime);
            yield return new WaitForEndOfFrame();
        }
    }
}
