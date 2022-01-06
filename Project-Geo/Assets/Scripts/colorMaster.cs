using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorMaster : MonoBehaviour
{
    public Fungus.Flowchart myFlow;
    [SerializeField] List<GameObject> pieces;
    [SerializeField] List<Color32> targetColors;
    public GameObject nextButton;
    public Button endbutton;
    public GameObject dontDestroy;
    public GameObject resultScreen;
    public GameObject bronze;
    public GameObject silver;
    public GameObject gold;
    public double timeElapsed;
    public Vector3 targetPosition = new Vector3(0, 8, 0);
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public int errors;
   

    void Start()
    {
        dontDestroy = GameObject.Find("DontDestroyOnLoad");
    }

    // Update is called once per frame
    public void CheckColors()
    {
        for(int i = 0;i<pieces.Count;i++)
        {
            if(pieces[i].GetComponent<SpriteRenderer>().color == targetColors[i])
            {
                pieces[i].GetComponent<colorizable>().correctColor = true;
                
            }
            
        }
        for( int i = 0; i < pieces.Count; i++)
        {
            if (!pieces[i].GetComponent<colorizable>().correctColor)
            {
                errors += 1;
                myFlow.ExecuteBlock("help");
                Debug.Log(i + "teil" + pieces[i].GetComponent<colorizable>().correctColor);
                break;
            }
            else
            {
                end();
                break;
            }
        }
       

    }
    public void end()
    {
        if (errors == 0 && Time.timeSinceLevelLoadAsDouble < 60)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            gold.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
            StartCoroutine(move());

            endbutton.gameObject.SetActive(true);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(1);
        }
        if (errors == 1 && Time.timeSinceLevelLoadAsDouble < 60)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            silver.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
            StartCoroutine(move());

            endbutton.gameObject.SetActive(true);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(2);
        }
        if (errors > 1 || Time.timeSinceLevelLoadAsDouble > 60)
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

    
    IEnumerator move()
    {
        while (resultScreen.transform.position != targetPosition)
        {
            resultScreen.transform.position = Vector3.SmoothDamp(resultScreen.transform.position, targetPosition, ref velocity, smoothTime);
            yield return new WaitForEndOfFrame();
        }
    }
}
