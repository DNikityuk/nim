using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class gamePropertiesView : MonoBehaviour {

    public Dropdown gameComplexity;
    public Dropdown numOfHeap;
    static int numberOfHeap;
    static int gameLevel;

    public void startGameClick() {
        if (numOfHeap.value != 0 && gameComplexity.value != 0) {
            numberOfHeap = numOfHeap.value + 1;
            gameLevel = gameComplexity.value;
            SceneManager.LoadScene("Game");
        }
    }

    public static int getNumberOfHeap() {
        return numberOfHeap;
    }
    
    public static int getGameLevel() {
        return gameLevel;
    }

}
