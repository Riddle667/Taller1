using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int actualScore = 0;

    private void Awake() {
        
        scoreText.text = "puntuacion: " + actualScore;
    }

    public void scoreUp(){
        actualScore += 1;
        scoreText.text = "puntuacion: " + actualScore;
    }
}
