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
    private Text Lb_Result = default;

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
        Lb_Result.text = "";
        Lb_Rank.text　= "";
        Lb_Top5.text = "";
        StartCoroutine(InitClearData());
    }

    IEnumerator InitClearData()
    {
        //タイマーの値をラベルに表示する。
        Lb_Result.text = "Your Score: " + scoreCount.getScore().ToString();

        yield return new WaitForSeconds(1.0f);

        /*クリア画面に表示する処理を書く*/

        //現在のランクをラベルにセットする
        SetYourRanking(Lb_Rank);

        yield return new WaitForSeconds(1.0f);

        /*トップ5まで表示する処理を書く*/
    }


    void SetYourRanking(Text Lb_Rank)
    {
        //ランキングに順位を設定します。
        //件数取得成功
        Lb_Rank.text = "RANK:" + "テスト順位"; // 自分よりスコアが上の人がn人いたら自分はn+1位
        Ranking.FetchTopRanker(Lb_Top5);
    }
}
