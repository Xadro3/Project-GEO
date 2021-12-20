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
    public int failures = 0;
    public int cardSet = 1;
    public int btnnmbr;

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
            SceneManager.LoadScene("Worldmap");
        }

        foreach(Button i in buttons)
        {
            i.gameObject.SetActive(true);
        }
        nextButton.gameObject.SetActive(false);
    }

}
