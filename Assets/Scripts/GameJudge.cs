using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameJudge : MonoBehaviour
{
    public PlayerJudge playerJudge;

    public Text showText ;

    private void Start()
    {
        showText.text = $"choice";
    }
   public void JudgeText(bool isWin)
    {
       
        if (isWin == true)
        {
            
           showText.text = $"win";
        }
        else
        {
            showText.text = $"lose"; 
        }
    }

    public void GameResultTextView(bool isWin)
    {
        if(isWin)
        {
            showText.text = "Playerの勝利です";
        }
        else
        {
            showText.text = "CPUの勝利です";
        }
    }
}
