using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {
    GameObject rockPrefab;
    float startX = -7f;
    float startY = 3f;
    int rockNumber;
    public Rock(int rockNum, int numHeap) {
        rockNumber = rockNum;
        showRock(numHeap);
    }

    void showRock(int numHeap) {
        float rockWidth = ((GameObject)Resources.Load("rock")).GetComponent<Renderer>().bounds.extents.x;
        float x = (startX + rockNumber * (2 * rockWidth + rockWidth / 2));
        float y = (startY - numHeap * (2 * rockWidth));
        Vector3 spawnPosition = new Vector3(x, y, 0.0f);
        Quaternion spawnRotation = Quaternion.identity;
        rockPrefab = (GameObject)Instantiate(Resources.Load("rock"), spawnPosition, spawnRotation);

    }

    public bool checkSelect() {
        if (rockPrefab.GetComponent<onRockListner>().getIsSelected() == 1) {
            return true;
        }
        return false;
    }

    public void deleteSelected() {
        rockPrefab.GetComponent<onRockListner>().deleteFromField();
    }

    public void setCanBeSelected(bool can) {
        rockPrefab.GetComponent<onRockListner>().setCanBeSelected(can);
    }
}
