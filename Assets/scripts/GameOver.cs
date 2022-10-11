using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TMP_Text actualScoretxt;
    public TMP_Text scoreRecordtxt;
    

    //Para convertir el record en string
    void Start()
    {
        //actualScoretxt.text = HudManager.instance.actualScore;
        //scoreRecordtxt.text = PlayerPrefs.GetInt("ScoreRecord",0).toString();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
