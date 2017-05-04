using UnityEngine;
public class rockGenerator : MonoBehaviour {
	int numOfHeaps;
    int gameLevel;
	public Heap[] heaps;
    ComputerPlayer cp;
    int selectedHeap = -1;
    int currentPlayer = 0;
    bool startPlay = false;
    public Canvas firstTurnView;
    public Canvas resultView;
	void Start () {
        gameLevel = gamePropertiesView.getGameLevel();
        numOfHeaps = gamePropertiesView.getNumberOfHeap();
        heaps = new Heap[numOfHeaps];
        for (int i = 0; i < numOfHeaps; i++) {
            heaps[i] = new Heap(i);
        }
        cp = new ComputerPlayer(this);
        blockAllHeaps(false);
        firstTurnView.GetComponent<firstTurnView>().setEnabled(true);
    }

    void Update () {
        if (canContinueGame() && startPlay) {
            if (currentPlayer == 0) {
                if (Input.GetKeyDown("return")) {
                    if (selectedHeap != -1) {
                        heaps[selectedHeap].deleteRocksFromHeap();
                        selectedHeap = -1;
                        setCurrentPlayer(1);
                    }
                }
                for (int i = 0; i < numOfHeaps; i++) {
                    if (heaps[i].hasRocks() && heaps[i].isSelectedHeap()) {
                        selectedHeap = i;
                        setblockHeaps(false);
                        break;
                    }
                    else {
                        selectedHeap = -1;
                        setblockHeaps(true);
                    }
                }
            }
            else {
                cp.Right_Step();
            }
        }
        else {
            if (startPlay) {
                string res;
                if (currentPlayer == 0) {
                    res = "Поражение";
                }
                else {
                    res = "Победа";
                }
                resultView.GetComponent<resultView>().setText(res);
                resultView.GetComponent<resultView>().setEnabled(true);
            }
        }
    }

    private void setblockHeaps(bool val) {
        for (int i = 0; i < numOfHeaps; i++) {
            if (heaps[i].hasRocks() && (val || getSelectedHeap() != i)) {
                heaps[i].setCanSelHeap(val);
            }
        }
    }

    private void blockAllHeaps(bool val) {
        for (int i = 0; i < numOfHeaps; i++) {
            heaps[i].setCanSelHeap(val);
        }
    }

    public int getSelectedHeap() {
        return selectedHeap;
    }

    public void setSelectedHeap(int sh) {
        selectedHeap = sh;
    }

    public int getNumberOfHeaps() {
        return numOfHeaps;
    }

    public int getNumberRocksInHeap(int heapNumber) {
        return heaps[heapNumber].getRockCount();
    }

    public void deleteSelectedCompRocks(int heapNumber, int numberOfRocks) {
        heaps[heapNumber].deleteCountOfRocks(numberOfRocks);
    }

    public void setCurrentPlayer(int player) {
        currentPlayer = player;
    }

    public void setStartPlayer(int player) {
        currentPlayer = player;
        blockAllHeaps(true);
        startPlay = true;
    }
    bool canContinueGame() {
        for(int i = 0; i < numOfHeaps; i++) {
            if (heaps[i].getRockCount() > 0)
                return true;
        }
        return false;
    }
}
