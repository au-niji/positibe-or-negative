using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remaining : MonoBehaviour
{
    [SerializeField]
    private Text RemainingText = default;
    public int remaining;
    int _remaining = -1;
    public void ReduseRemaining()
    {
        //正解したときに減らします。
        _remaining--;
        // RemainingText.text = "残り:" + _remaining.ToString();
    }

    public void ResetRemaining()
    {
        //ゲーム開始時にリセットすること
        _remaining = remaining;
        // RemainingText.text = "残り:" + _remaining.ToString();
    }

    public int GetRemaining()
    {
        //残り数を返します。
        return _remaining;
    }

    private void Start()
    {
        ResetRemaining();    
    }

}
