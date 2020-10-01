using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoints : MonoBehaviour
{

    public static float scorePoints;
    public static float highScore;
    public static string pontosTXT;
    public static string pontosRecordeTXT;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
       // scorePoints = (int)Time.timeSinceLevelLoad;
        score = GetComponent<Text>();
        scorePoints = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        scorePoints = Time.timeSinceLevelLoad;
        pontosTXT = scorePoints.ToString("n2");
        pontosTXT = pontosTXT.Replace(",", "");
        pontosRecordeTXT = highScore.ToString("n2");
        pontosRecordeTXT = pontosRecordeTXT.Replace(",", "");
        score.text = "Recorde: " + pontosRecordeTXT + " " +
            "   Pontuação: " + pontosTXT;
    }
}
