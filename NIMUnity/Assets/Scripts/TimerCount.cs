using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerCount : MonoBehaviour {
    Text text;
    float startTime;
    public int num;

    void Start() {
        startTime = Time.time;
        text = GetComponent<Text>();
    }
	
    
	void Update () {
        float t = Time.time - startTime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f0");
        text.text = "Время: " + min + ":" + sec;
	}

}
