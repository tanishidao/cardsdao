using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    public GameJudge gameJudge;
    public Text playerText;
    public Text cpuText;

    public static int playerPoints = 0;
    public static int cpuPoints = 0;
    private void Start()
    {
        
        playerText.text = $"0";
        cpuText.text = $"0";
    }

    public void kasan(bool plus)
    {

        if (plus == true)
        {
            playerPoints += 2;

            playerText.text = $"{playerPoints}";

        }
        else
        {
              cpuPoints += 2;
            cpuText.text = $"{cpuPoints}";



        }
    }
}
