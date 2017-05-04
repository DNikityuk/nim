using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modeGameView : MonoBehaviour {

    public Canvas gameProperties;

    // Use this for initialization
    void Start () {
        gameProperties.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ordinaryGameClick()
    {
        gameProperties.GetComponent<Canvas>().enabled = true;
    }
}
