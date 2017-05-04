using UnityEngine;
using System.Collections;

public class onRockListner : MonoBehaviour {
    int isSelected = 0;
    bool canBeSelected = true;
    int position = 0;
    float x;
    float y;
	void Start () {
        x = transform.position.x;
        y = transform.position.y;
    }

	void OnMouseDown() {
        if(isSelected == 0 && canBeSelected) {
            isSelected = 1;
            StartCoroutine(shake());
        }
        else {
            isSelected = 0;
            StopCoroutine(shake());
        }
    }
	void Update () {

    }

    public IEnumerator shake() {
        while (isSelected == 1) {
            switch (position) {
                case 0:
                    transform.Translate(0.0f, 0.05f, 0.0f);
                    position = 1;
                    break;
                case 1:
                    transform.Translate(0.0f, -0.1f, 0.0f);
                    position = -1;
                    break;
                case -1:
                    transform.Translate(0.0f, 0.1f, 0.0f);
                    position = 1;
                    break;
            }
            yield return new WaitForSeconds(0.2f);
        }
        transform.position = new Vector2(x, y);
        position = 0;
    }

    public int getIsSelected() {
        return isSelected;
    }

    public void deleteFromField() {
        Destroy(gameObject);
    }

    public void setCanBeSelected(bool cbs) {
        canBeSelected = cbs;
    }
}
