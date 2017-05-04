using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuView : MonoBehaviour {
    
    public Canvas modeGame;

    void Start() {        
        modeGame.GetComponent<Canvas>().enabled = false;
    }

	public void ratingGameClick() {
        modeGame.GetComponent<Canvas>().enabled = true;
        //gameProperties.GetComponent<Canvas>().enabled = true;
    }


    public void exitClick() {
        Application.Quit();
    }

    public void trainingGameClick() {
        //SceneManager.LoadScene("TrainingGame");
    }

    public void optionsClick() {
        //SceneManager.LoadScene("Options");
    }
}
