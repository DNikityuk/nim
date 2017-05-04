using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamesView : MonoBehaviour {

    //public Canvas gameProperties;

    // Use this for initialization
    void Start () {
        Screen.SetResolution(800, 600, false);
        //gameProperties.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	//void Update () {
	//
	//}

    public void oridinalGameClick()
    {
        //gameProperties.GetComponent<Canvas>().enabled = true;
        SceneManager.LoadScene("MenuWindow");       
    }
}
