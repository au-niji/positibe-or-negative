using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text TimeText = default;
    bool timer_switch;
    public int time; // Unity側で設定する初期値が反映される
    private int _time = 1;
    private float count;
    void Update()
    {
        if(timer_switch)
        {
            count += Time.deltaTime;
            if(count >= 1.0f)
            {
                count = 0.0f;
                _time -= 1;
            }
            
            TimeText.text = _time.ToString();
        }
    }
    public void StartTimer()
    {
        timer_switch = true;
    }
    public void ResetTimer()
    {
        _time = time;
        TimeText.text = _time.ToString();
        timer_switch = false;
    }
    public int GetTimer()
    {
        return _time;
    }

}
