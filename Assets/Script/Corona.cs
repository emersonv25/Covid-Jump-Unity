using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Corona : MonoBehaviour
{

    [SerializeField]
    float jumpforce;

    [SerializeField]
    bool canjump;



    private Rigidbody2D rb;
    //private Animator ani;

    public static string pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //ani = GetComponent<Animator>();
        canjump = true;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            if (canjump == true)
            {
                rb.AddForce(Vector2.up * jumpforce);
                canjump = false;
                //ani.SetBool("jump", true);

            }
        }

    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Ground"))
        {
            canjump = true;
            //ani.SetBool("jump", false);

        }

        if (colisao.gameObject.CompareTag("Obstacle"))
        {
            if (ScorePoints.highScore < ScorePoints.scorePoints)
            {
                ScorePoints.highScore = ScorePoints.scorePoints;
            }
            Obstacle.speed = -0.1f;
            pontuacao = ScorePoints.pontosTXT;
            SceneManager.LoadScene("GameOver");

        }
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }


}
