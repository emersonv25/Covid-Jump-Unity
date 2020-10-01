using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogar : MonoBehaviour
{
    public static string score;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        score = Corona.pontuacao ;
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Recorde: " + ScorePoints.pontosRecordeTXT + " Pontuação: " + score +"\nGAME OVER !\nToque na tela para jogar Novamente";

        if(Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("dinorun");

        }
    }
}
