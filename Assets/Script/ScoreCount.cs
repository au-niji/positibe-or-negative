using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCount : MonoBehaviour
{

    [SerializeField] public Text scoreText = default;
    private int score;
    // 呼び出された際に初期化
    
    // 正解時にスコアを追加する
    public void incrementScore() {
        this.score += 1;
        writeScore();
    }

    // スコアを適応する
    public void writeScore() {
        scoreText.text = this.score.ToString();
    }
    // スコアのゲッター
    public int getScore() {
        return this.score;
    }
    // スコアのリセット用の関数
    public void resetScore() {
        this.score = 0;
    }
}
