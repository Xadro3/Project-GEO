using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizmaster : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    [SerializeField] List<Button> buttons;
    private int btnnmbr;

    public void answer(bool selection)
    {
        if (selection)
        {
            buttons[btnnmbr].GetComponent<Image>().color = new Color32(0, 255, 0, 50);
            buttons.RemoveAt(btnnmbr);

            foreach (Button i in buttons)
            {
                i.gameObject.SetActive(false);
            }
            
        }
        else
        {
            buttons[btnnmbr].GetComponent<Image>().color = new Color32(255, 0, 0, 50);
            
        }
        
    }
    public void index (int btn)
    {
        btnnmbr = btn;
    }
}
