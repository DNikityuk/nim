using UnityEngine;
using System.Collections;

public class ComputerPlayer : MonoBehaviour {
    rockGenerator rockGen;

    public ComputerPlayer(rockGenerator rg) {
        rockGen = rg;
    }

    public void makeStep() {

    }

    int xor_sum_Find() {
        int xor_sum = 0;
        for (int i = 0, n = rockGen.getNumberOfHeaps(); i < n; i++)
            xor_sum = (xor_sum ^ rockGen.getNumberRocksInHeap(i));
        return xor_sum;
    }

    public void Right_Step() {
        int xor_sum = xor_sum_Find(), difference;
        if (xor_sum == 0) {
            wrongStep();
            return;
        }
        for (int i = 0, n = rockGen.getNumberOfHeaps(); i < n; i++) {
            int rocksInHeap = rockGen.getNumberRocksInHeap(i);
            xor_sum = (xor_sum ^ rocksInHeap);
            if (rocksInHeap >= xor_sum) {
                difference = rocksInHeap - xor_sum;
                rocksInHeap = xor_sum;
                rockGen.deleteSelectedCompRocks(i, difference);
                endTurn();
                break;
            }
            xor_sum = (xor_sum ^ rocksInHeap);
        }
    }

    void endTurn() {
        rockGen.setCurrentPlayer(0);
    }

    void wrongStep() {
        int xor_sum = 0;
        while (true) {
            int numberHeap = Random.Range(0, rockGen.getNumberOfHeaps());
            int rocksInHeap = rockGen.getNumberRocksInHeap(numberHeap);
            if (rocksInHeap == 0) continue;
            int difference = Random.Range(1, rocksInHeap + 1);
            if (difference != xor_sum)
                if (rocksInHeap >= difference) {
                    rockGen.deleteSelectedCompRocks(numberHeap, difference);
                    endTurn();
                    break;
                }
        }
     }
}
