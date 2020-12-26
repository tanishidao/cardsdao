using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighAndLowSequence : MonoBehaviour
{
    private enum GameSequence
    {
        Invalide,
        Init,
        Start,
        Deal,
        PlayerJudge,
        Show,
            Result
    }

    private GameSequence gameSequence = GameSequence.Invalide;

    public Dealer dealer;

    public PlayerCard playerCard;

    public CPUCard cpuCard;

    public PlayerJudge playerJudge;

    public GameJudge gameJudge;

    public ScoreViewer scoreViewer;

    public float waitTime = 1.5f;

    
   

    void Update()
    {
        switch (gameSequence)
        {

            case GameSequence.Invalide:

                gameSequence = GameSequence.Init;
                break;
            case GameSequence.Init:

                playerCard.SetPlayerDeck();
                cpuCard.SetCPUDeck();
                gameSequence = GameSequence.Start;
                break;
            case GameSequence.Start:

                gameSequence = GameSequence.Deal;
                break;
            case GameSequence.Deal:
                //playerとCPUにデッキをディール
                playerCard.SetPlayerCard();
                cpuCard.SetCPUCard();

                Debug.Log(playerCard.playerCard.Number);
                Debug.Log(cpuCard.cpuCard.Number);
                gameSequence = GameSequence.PlayerJudge;
                break;
            case GameSequence.PlayerJudge:
                //数を予想してボタンを押したらShowに進む
                if (playerJudge.Judge)
                {
                    gameSequence = GameSequence.Show;
                }
                break;
            case GameSequence.Show:
                //Playerが確認したらStartに戻って次のゲームへ行く
                cpuCard.ShowCPUCard();

                bool win = false;
                if (playerJudge.High)
                {
                    
                    if (playerCard.playerCard.Number > cpuCard.cpuCard.Number)
                    {

                        win = true;
                   
                    }
                }
                else
                {
                    if (playerCard.playerCard.Number < cpuCard.cpuCard.Number)
                    {
                        win = true;
                        
                    }
                    
                }


                gameJudge.JudgeText(win);
                waitTime -= Time.deltaTime;

                if (waitTime < 0f)
                {
                    playerJudge.Judge = false;
                    
                    if(dealer.GameEnd(playerCard.GetPlayerDeck()))
                    {
                        gameSequence = GameSequence.Result;
                    }
                    else
                    {
                        gameSequence = GameSequence.Start;
                    }
                    scoreViewer.kasan(win);
                    waitTime = 1f;
                }
                break;
            case GameSequence.Result:

                bool isResultWin = false;
                int Playerpoints = ScoreViewer.playerPoints;
                int Cpupoints = ScoreViewer.cpuPoints;
                if (Playerpoints > Cpupoints)
                   
                {
                    isResultWin = true;
                }
                gameJudge.GameResultTextView(isResultWin);
                waitTime = 1f;
                SceneManager.LoadScene(sceneName: "GameResult");
                break;

            
        }
    }
}
