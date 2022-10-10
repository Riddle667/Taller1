using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int actualScore = 0;
    public static HudManager instance;

    private void Awake() {
        if(instance == null){
            instance = this;
        }
        scoreText.text = "puntuacion: " + actualScore;
    }

    public void scoreUp(){
        actualScore += 1;
        scoreText.text = "puntuacion: " + actualScore;
    }
}
