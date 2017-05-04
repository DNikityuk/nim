using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuView : MonoBehaviour {
    
    public Canvas gameProperties;

    void Start() {
        gameProperties.GetComponent<Canvas>().enabled = false;
    }

	public void ratingGameClick() {
       gameProperties.GetComponent<Canvas>().enabled = true;
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
