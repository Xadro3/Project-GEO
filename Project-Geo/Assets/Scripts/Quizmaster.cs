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


    public int failures = 0;
    public int cardSet = 1;
    public int btnnmbr;
    public double timeElapsed;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public Vector3 targetPosition = new Vector3(0, 8, 0);
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
        }
        if(cardSet == 3)
        {
            buttons.Clear();
            buttons = nextbuttonset2;
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
        }
        if (failures >0 || Time.timeSinceLevelLoadAsDouble > 60)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            silver.gameObject.SetActive(true);
            StartCoroutine(move());
            endButton.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
        }
        if (failures >= 1 && Time.timeSinceLevelLoadAsDouble > 60)
        {
            nextButton.gameObject.SetActive(false);
            timeElapsed = Time.timeSinceLevelLoadAsDouble;
            bronze.gameObject.SetActive(true);
            StartCoroutine(move());
            endButton.gameObject.SetActive(true);
            Debug.Log(timeElapsed);
            
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