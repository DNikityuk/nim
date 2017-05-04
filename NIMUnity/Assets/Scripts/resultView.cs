﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resultView : MonoBehaviour {
    
    void Start() {
        GetComponent<Canvas>().enabled = false;
    }

	public void setText(string result) {
        GetComponentInChildren<Text>().text = result;
    }

    public void setEnabled(bool val) {
        GetComponent<Canvas>().enabled = val;
    }

    public void playAgain() {
        SceneManager.LoadScene("Game");
    }

}
