using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kekkahyouji : MonoBehaviour
{
    public Text ResultText;


    

    public void GameResultText()
    {
        int Playerpoints = ScoreViewer.playerPoints;
        int Cpupoints = ScoreViewer.cpuPoints;

        if ( Playerpoints > Cpupoints)
        {
            ResultText.text = "あんた勝者！";
        }
        else
        {
            ResultText.text = "あんた負けた！";
        }
    }
}
