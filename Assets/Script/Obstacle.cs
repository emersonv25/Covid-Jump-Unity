using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    public static float speed = -0.1f;
   // private Rigidbody2D obstacle;

    void Start()
    {
        //speed = -0.1f;
        //obstacle = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        // Seta a velocidade
        transform.Translate(speed, 0, 0);


        // quando chegar em tau posição ele irá se destruir.
        if (transform.position.x <= -7f )
        {
            Destroy(this.gameObject);
            
        }

        
    }

}


