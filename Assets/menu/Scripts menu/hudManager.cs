using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hudManager : MonoBehaviour
{
    public TMP_Text actualScore;

    private void Awake() {
        
        actualScore.text = "puntuacion: " + 0;
    }
}
