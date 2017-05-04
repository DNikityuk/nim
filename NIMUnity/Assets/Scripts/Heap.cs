using UnityEngine;
using System.Collections;

public class Heap : MonoBehaviour {
    private Rock[] rocks;
    int heapNumber;
    int rockCount;

    public Heap(int heapNum) {
        heapNumber = heapNum;
        rocks = new Rock[Random.Range(1, 7)];
        for (int i = 0; i < rocks.Length; i++) {
            rocks[i] = new Rock(i, heapNumber);
        }
        rockCount = rocks.Length;

    }

    void Update() {
    }
    
    public void deleteRocksFromHeap() {
        for (int i = rockCount - 1; i >= 0; i--) {
            if (rocks[i].checkSelect()) {
                rockCount--;
                rocks[i].deleteSelected();
            }
        }
    }

    public bool isSelectedHeap() {
        for (int i = 0; i < rockCount; i++) {
            if (rocks[i].checkSelect()) {
                return true;
            }
        }
        return false;
    }

    public void setCanSelHeap(bool csh) {
        for (int i = 0; i < rockCount; i++) {
            rocks[i].setCanBeSelected(csh);
        }
    }

    public bool hasRocks() {
        if (rockCount > 0) {
            return true;
        }
        return false;
    }

    public int getRockCount() {
        return rockCount;
    }

    public void deleteCountOfRocks(int numberOfRocks) {
        for (int i = rockCount - 1, n = rockCount - numberOfRocks; i >= n; i--) {
            rockCount--;
            rocks[i].deleteSelected();
        }
    }
}
