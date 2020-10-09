using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text[] TimerTex;
    public float LeftTime = 0;

    public void StartCoundownTimer()
    {
         InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
    }

    void UpdateTimer()
    {
        for (int i = 0; i < TimerTex.Length; i++)
        {
            LeftTime -= Time.deltaTime;
            string minutes = Mathf.Floor(LeftTime / 60).ToString("00");
            string seconds = (LeftTime % 60).ToString("00");
            string fraction = ((LeftTime * 100) % 100).ToString("000");
            TimerTex[i].text = "" + minutes + ":" + seconds + ":" + fraction;
        }
    }
}
