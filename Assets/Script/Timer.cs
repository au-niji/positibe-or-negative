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
    float time;
    void Update()
    {
        if(timer_switch)
        {
            time += Time.deltaTime;
            TimeText.text = time.ToString("F3");
        }
    }
    public void StartTimer()
    {
        time = 0.0f;
        timer_switch = true;
    }
    public void ResetTimer()
    {
        time = 0.0f;
        TimeText.text = time.ToString("F3");
        timer_switch = false;
    }
    public float GetTimer()
    {
        return time;
    }
}
