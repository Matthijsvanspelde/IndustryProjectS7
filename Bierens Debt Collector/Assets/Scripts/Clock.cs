using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class Clock : MonoBehaviour
{
    public Text textClock;

    private DateTime time;
    private string hour;
    private string minute;

    void Update()
    {
        time = DateTime.Now;
        hour = LeadingZero(time.Hour);
        minute = LeadingZero(time.Minute);
        textClock.text = hour + ":" + minute;
    }
    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}