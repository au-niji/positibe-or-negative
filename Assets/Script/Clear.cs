using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using System;

public class Clear : MonoBehaviour
{
    [SerializeField]
    private Timer Timer = default;
    [SerializeField]
    private Text Lb_Timer = default;
    [SerializeField]
    private Text Lb_Rank = default;

    [SerializeField]
    private Text Lb_Top5 = default;
    [SerializeField]
    private Text Lb_Score = default;

    [SerializeField]
    private GameManager GameManager = default;

    [SerializeField]
    private Ranking Ranking = default;

    [SerializeField]
    private ScoreCount scoreCount = default;

    //タイマーの値をラベルに表示する。
    //ランキングを取得し、順位を表示する。

    public void OnEnable() 
    {
        //初期化
        Lb_Score.text = "";
        Lb_Rank.text　= "";
        Lb_Top5.text = "";
        StartCoroutine(InitClearData());
    }

    IEnumerator InitClearData()
    {
        // スコアの値をラベルに表示する。
        Lb_Score.text = scoreCount.getScore().ToString();

        yield return new WaitForSeconds(1.0f);

        yield return new WaitForSeconds(1.0f);
    }

    void SetYourRanking(float yourtime,Text Lb_Rank)
    {
    }

}
