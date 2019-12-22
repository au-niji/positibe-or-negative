using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject Balls = default;

    [SerializeField]
    private Remaining OBJ_ReMaining = default;
    [SerializeField]
    private ScoreCount scoreCount = default;

    [SerializeField]
    private Button Bt_Plus = default;

    [SerializeField]
    private Button Bt_Zero = default;

    [SerializeField]
    private Button Bt_Minus = default;

    private AudioSource Correct;
    private AudioSource Miss;

    void Start() 
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        Correct = audioSources[0];
        Miss = audioSources[1];
    }



    public void Onclick(int button) // -1 or 0 or +1
    {


        int total = 0;
        List<Ball> BallsSC = new List<Ball>{};
        foreach (Transform childTransform in Balls.transform)
        {
            BallsSC.Add(childTransform.GetComponent<Ball>());
        }

        foreach (Ball Ball in BallsSC)
        {
            total += Ball.GetNumber();
        }

        //答え合わせ
        if ((button <  0 && total <  0) ||
            (button >  0 && total >  0) ||
            (button == 0 && total == 0)
           )
        {
            //正解
            Correct.PlayOneShot(Correct.clip);  //SE
            OBJ_ReMaining.ReduseRemaining();
            scoreCount.incrementScore();
            foreach (Ball Ball in BallsSC)
            {
                Ball.SetText();
            }
        }
        else
        {
            //不正解
            Miss.PlayOneShot(Miss.clip);  //SE
            StartCoroutine(MissWait());
        }
    }

    IEnumerator MissWait()
    {
        
        //ボタン三つを一時的に無効化する
        Bt_Minus.interactable = false;
        Bt_Zero.interactable  = false;
        Bt_Plus.interactable  = false;
        yield return new WaitForSeconds(1.0f);

        Bt_Minus.interactable = true;
        Bt_Zero.interactable  = true;
        Bt_Plus.interactable  = true;
        yield break;
    }

}
