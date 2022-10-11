using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int actualScore = 0;
    public static HudManager instance;
    public GameObject panelGameOver;
    public TMP_Text scoreRecordtxt;
    private int scoreRecord; 

    private void Awake() {
        if(instance == null){
            instance = this;
        }
        scoreText.text = "puntuacion: " + actualScore;

        scoreRecord = PlayerPrefs.GetInt("ScoreRecord",0);
    }

    
    //Esta función va haciendo que el puntaje suba durante la partida
    public void scoreUp(){
        actualScore += 1;
        scoreText.text = "puntuacion: " + actualScore;

    }

    //Esta función degine el record
    public void ScoreRecord()
    {
        if(actualScore>PlayerPrefs.GetInt("ScoreRecord",0))
        {
            PlayerPrefs.SetInt("ScoreRecord",actualScore);
        }
    }
}
