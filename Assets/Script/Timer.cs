using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text TimeText = default;
    // Update is called once per frame

    bool timer_switch;
    public static int time = 30;
    private int _time = time;
    private float count;
    void Update()
    {
        if(timer_switch)
        {
            count += Time.deltaTime;
            if(count >= 1.0f)
            {
                count = 0.0f;
                time -= 1;
            }
            
            TimeText.text = time.ToString();
        }
    }
    public void StartTimer()
    {
        time = _time;
        timer_switch = true;
    }
    public void ResetTimer()
    {
        time = _time;
        TimeText.text = time.ToString();
        timer_switch = false;
    }
    public int GetTimer()
    {
        return time;
    }

}
