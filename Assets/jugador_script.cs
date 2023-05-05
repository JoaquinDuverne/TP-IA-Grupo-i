using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jugador_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public float velocidad;
    public bool vivo = true;

    public void matarJugador()
    {
        vivo = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        myRigidbody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.DownArrow) && vivo)
        {
            myRigidbody.velocity = Vector2.down * velocidad;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && vivo)
        {
            myRigidbody.velocity = Vector2.up * velocidad;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && vivo)
        {
            myRigidbody.velocity = Vector2.right * velocidad;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && vivo)
        {
            myRigidbody.velocity = Vector2.left * velocidad;
        }


        if ((Input.GetKey(KeyCode.DownArrow) == false) & (Input.GetKey(KeyCode.UpArrow) == false) & 
            (Input.GetKey(KeyCode.LeftArrow) == false) & (Input.GetKey(KeyCode.RightArrow) == false))
        {
            myRigidbody.velocity = Vector2.zero;
        }
        
        if (logic.playerScore == 0)
        {
            vivo = false;
        }

        if (logic.playerScore == 14)
        {
            velocidad = 7;
        }
    }
   
}
