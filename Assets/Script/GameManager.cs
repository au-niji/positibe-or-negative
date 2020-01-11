using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text _textCountdown = default;
    [SerializeField]
    private GameObject Balls = default;
    [SerializeField]
    private Timer Timer = default;
    [SerializeField]
    private Remaining Remaining = default;
    [SerializeField]
    private ScoreCount ScoreCount = default;
    [SerializeField]
    private GameObject Main = default;
    [SerializeField]
    private GameObject Title = default;
    [SerializeField]
    private GameObject Pause = default;
    [SerializeField]
    private GameObject Clear = default;
    [SerializeField]
    private MainButtonManager MainBtnMng = default;

    [SerializeField]
    private InputField inputField = default;

    private AudioSource SE_Countdown;
    private AudioSource SE_Start;

    float SET_COUNT = 0.5f;
    float countdown_timer;
    List<Ball> BallsSC = new List<Ball> {};

    string yourname = "No name";
    
    void Start() 
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        SE_Countdown = audioSources[0];
        SE_Start = audioSources[1];
    }

    public void OnClick()
    {
        //有効になったタイミングでカウントダウンを始める。
        //設定した時間だけ経過したら、ゲームのロジックをスタートさせる。
        Main.SetActive(true);
        Title.SetActive(false);
        MainBtnMng.DisableMainButton(); //カウントダウン中はボタンを無効化
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        //残り回数初期化
        Remaining.ResetRemaining();

        _textCountdown.gameObject.SetActive(true);

        _textCountdown.text = "3";
        SE_Countdown.PlayOneShot(SE_Countdown.clip);  //SE
        yield return new WaitForSeconds(SET_COUNT);

        _textCountdown.text = "2";
        SE_Countdown.PlayOneShot(SE_Countdown.clip);  //SE
        yield return new WaitForSeconds(SET_COUNT);

        _textCountdown.text = "1";
        SE_Countdown.PlayOneShot(SE_Countdown.clip);  //SE
        yield return new WaitForSeconds(SET_COUNT);

        _textCountdown.text = "GO!";
        SE_Start.PlayOneShot(SE_Start.clip);  //SE
        GameStart();
        yield return new WaitForSeconds(SET_COUNT);

        _textCountdown.text = "";
        _textCountdown.gameObject.SetActive(false);
    }
    void GameStart()
    {
        BallsSC.Clear();
        foreach (Transform childTransform in Balls.transform)
        {
            BallsSC.Add(childTransform.GetComponent<Ball>());
        }

        //ボタンを有効化
        MainBtnMng.EnableMainButton();

        //タイマー起動
        Timer.ResetTimer();
        Timer.StartTimer();
        //ボールのテキストをセット
        foreach (Ball Ball in BallsSC)
        {
            Ball.SetText();
        }
    }

    public void Retry()
    {
        GameReset();
        OnClick();
    }

    void GameReset()
    {
        
        //タイマーリセット
        Timer.ResetTimer();
        ScoreCount.resetScore();
        ScoreCount.writeScore();
        //ボールのテキストをクリア
        foreach (Ball Ball in BallsSC)
        {
            Ball.ResetText();
        }
        //スイッチ切り替え
        Pause.SetActive(false);
        Clear.SetActive(false);
    }

    void ClearCheck()
    {
        // 時間が0秒になったら終了
        if(Timer.GetTimer() <= 0)
        {
            Clear.SetActive(true);
            Timer.ResetTimer();
            // Timer.stopTime(true);
            Debug.Log("Game Clear");
        }
    }
    public void GotoTitle()
    {
        //Title画面に移動する
        GameReset();
        Main.SetActive(false);
        Pause.SetActive(false);
        Title.SetActive(true);
    }

    public void SetYourName()
    {
        yourname = inputField.text;
    }
    public string GetYourName()
    {
        return yourname;
    }

    private void Update()
    {
        ClearCheck();
    }

}