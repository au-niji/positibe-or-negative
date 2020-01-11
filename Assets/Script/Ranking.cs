using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public bool Rankupdate = false; //ランキングを更新したかを判定。
    [SerializeField]
    private Text Rank_Lb_Top5 = default;

    [SerializeField]
    private Text Clear_Lb_Top5 = default;
    [SerializeField]
    private ScoreCount scoreCount = default;

    // 名前とリザルトを使ってランキングに登録する処理を書く
    public void SaveRanking(string name, float time)
    {
    }

    // ランキングのトップ5を出力する処理を書く
    public void ShowTopRanker()
    {
        FetchTopRanker(Rank_Lb_Top5);
        FetchTopRanker(Clear_Lb_Top5);
    }

    // ランキングに表示するためのメソッド
    public void FetchTopRanker(Text label)
    {
        int max = 6;
        label.text = "";

        int count = 1;
        for (; count < max; count++)
        {
            string n = "name";
            label.text += (count + ":" + n + "\n").ToString();
        }
        Rankupdate = true; 
    }

    private void OnEnable() 
    {
        ShowTopRanker();
    }
}