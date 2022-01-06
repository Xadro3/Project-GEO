using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quizmaster : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    [SerializeField] List<Button> buttons;
    [SerializeField] List<Button> nextbuttonset;
    [SerializeField] List<Button> nextbuttonset2;
    [SerializeField] Button nextButton;
    [SerializeField] Button endButton;
    [SerializeField] GameObject resultScreen;
    [SerializeField] GameObject bronze;
    [SerializeField] GameObject silver;
    [SerializeField] GameObject gold;
    [SerializeField] GameObject text;
    [SerializeField] GameObject text_1;
    [SerializeField] GameObject text_2;

    public GameObject dontDestroy;
    public int failures = 0;
    public int cardSet = 1;
    public int btnnmbr;
    public double timeElapsed;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public Vector3 targetPosition = new Vector3(0, 8, 0);

    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroyOnLoad");
    }
    public void answer(bool selection)
    {
        if (selection)
        {
            buttons[btnnmbr].GetComponent<Image>().color = new Color32(0, 255, 0, 50);
            

            nextButton.gameObject.SetActive(true);
            cardSet += 1;
            
            
        }
        else
        {
            buttons[btnnmbr].GetComponent<Image>().color = new Color32(255, 0, 0, 50);
            failures += 1;
        }
        
    }
    public void index (int btn)
    {
        btnnmbr = btn;
    }
    public void cardManger()
    {
        foreach (Button i in buttons)
        {
            i.gameObject.SetActive(false);
        }
        if (cardSet == 2)
        {
            buttons.Clear();
            buttons = nextbuttonset;
            text.gameObject.SetActive(false);
            text_1.gameObject.SetActive(true);
        }
        if(cardSet == 3)
        {
            buttons.Clear();
            buttons = nextbuttonset2;
            text_1.gameObject.SetActive(false);
            text_2.gameObject.SetActive(true);
        }
        if(cardSet == 4)
        {
            end();
        }

        foreach(Button i in buttons)
        {
            i.gameObject.SetActive(true);
        }
        nextButton.gameObject.SetActive(false);
    }
    public void end()
    {
        
        if(failures == 0 && Time.timeSinceLevelLoadAsDouble < 60)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            gold.gameObject.SetActive(true);
            StartCoroutine(move());
            
            
            Debug.Log(timeElapsed);
            endButton.gameObject.SetActive(true);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(1);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games.Add(true);
        }
        if (failures ==1 && Time.timeSinceLevelLoadAsDouble < 60)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            silver.gameObject.SetActive(true);
            StartCoroutine(move());
            endButton.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(2);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games.Add(true);
        }
        if (failures > 1 || Time.timeSinceLevelLoadAsDouble > 60)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            bronze.gameObject.SetActive(true);
            StartCoroutine(move());
            endButton.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().resutls.Add(3);
            dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games.Add(true);

        }
    }
    public void nextScene()
    {
        dontDestroy.GetComponent<DontDestroyOnLoad_MapKeys>().solved_games.Add(true);
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
