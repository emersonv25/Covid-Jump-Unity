using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    [SerializeField]
    float jumpforce;

    [SerializeField]
    bool canjump;



    private Rigidbody2D rb;
    private Animator ani;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        canjump = true;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (canjump == true)
            {
                rb.AddForce(Vector2.up * jumpforce);
                canjump = false;
                ani.SetBool("jump", true);

            }


        }
        
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Ground"))
        {
            canjump = true;
            ani.SetBool("jump", false);

        }

        if (colisao.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("dinorun");
            
        }
    }

   
}


