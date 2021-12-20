using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farbewechsel : MonoBehaviour
{
    public GameObject panel;

    public SpriteRenderer head;
    public Image squareHeadDiyplay;

    public Color[] colors;
    public int whatColor = 1;

    private void Update()
    {
        squareHeadDiyplay.color = head.color;

        for (int i = 0; i < colors.Length; i++)
        {
            if(i == whatColor)
            {
                head.color = colors[i];
            }
        }
    }

    public void ChangePanelState(bool state)
    {
        panel.SetActive(state);
    }
    
    public void ChangeHeadColor(int index)
    {
        whatColor = index;
    }
}
