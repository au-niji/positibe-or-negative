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
    public void SaveRanking(string name, float time)
    {
        //名前とタイムでランキングを登録します。
        // NCMBObject PositiveOrNegative = new NCMBObject("PositiveOrNegative");
        // PositiveOrNegative["name"] = name;
        // PositiveOrNegative["time"] = time;
        // データストアへの登録
        // PositiveOrNegative.Save();
    }

    public void ShowTopRanker()
    {
        //既に一度読み込んでいるなら、Clearの文字列を表示。
        //まだ読み込んでないなら、データリストを読み込む
        // if (!Rankupdate)
        // {
        //     FetchTopRanker(Rank_Lb_Top5);
        //     FetchTopRanker(Clear_Lb_Top5);
        // }
        // else
        // {
        //     Rank_Lb_Top5.text = Clear_Lb_Top5.text;
        // }

    }

    public void FetchTopRanker(Text label)
    {
        //トップファイルを取得して、テキストオブジェクトに記載します。

        // label.text = "";

        // NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("PositiveOrNegative");
        // query.OrderByAscending("time");
        // query.Limit = 5;
        // query.Find((List<NCMBObject> objList, NCMBException e) =>
        // {

        //     if (e != null)
        //     {
        //         //検索失敗時の処理
        //         Debug.Log("TOP5ランキングの取得に失敗しました。");
        //         label.text = "failed Get Ranking";
        //     }
        //     else
        //     {
        //         //検索成功時の処理
        //         int count = 1;
        //         foreach (NCMBObject obj in objList)
        //         {
        //             //timerを xxx.xxx形式に整形する
        //             float time = System.Convert.ToSingle(obj["time"]);
        //             string t = time.ToString("F3").PadLeft(7,'0');
        //             string n = string.Format("{0, -8}",System.Convert.ToString(obj["name"]));
        //             label.text += (count + ":" + n + ":" + t + "\n").ToString();
        //             count++;
        //         }
        //         Rankupdate = true;
        //     }
        // });
    }

    private void OnEnable() 
    {
        ShowTopRanker();
    }
}
