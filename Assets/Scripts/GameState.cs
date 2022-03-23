using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public float timerStart = 120;
    private float timerCurrent;
    private float currentScore;
    public float getScore(){
        return currentScore;
    }
    public void addScore(float scoreDelta){
        currentScore += scoreDelta;
    }
    public float getTime(){
        return timerCurrent;
    }

    public void Start(){
        timerCurrent = timerStart;
    }

    public void Update(){
        if (timerCurrent - Time.deltaTime >= 0) timerCurrent -= Time.deltaTime;
        else timerCurrent = 0;
    }
}