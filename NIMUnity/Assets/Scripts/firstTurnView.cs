using UnityEngine;
using System.Collections;

public class firstTurnView : MonoBehaviour {

    public rockGenerator rockGen;

    void Start () {
        GetComponent<Canvas>().enabled = false;
    }

	public void yesClickButton() {
        rockGen.setStartPlayer(0);
        setEnabled(false);
    }

    public void noClickButton() {
        rockGen.setStartPlayer(1);
        setEnabled(false);
    }

    public void setEnabled(bool val) {
        GetComponent<Canvas>().enabled = val;
    }
}
