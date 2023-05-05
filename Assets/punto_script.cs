using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punto_script : MonoBehaviour
{
    public LogicScript logic;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        logic.addScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.restaScore();
        Destroy(gameObject);

        if (logic.playerScore == 0)
        {
            logic.terminarJuego();
        }
    }
}
