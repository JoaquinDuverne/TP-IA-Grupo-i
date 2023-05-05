using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agent_movement : MonoBehaviour
{
    private Vector3 target;
    NavMeshAgent agent;
    public LogicScript logic;
    public SpriteRenderer sprite;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        SetTargetPosition();
        SetAgentPosition();

        if (logic.playerScore == 14)
        {
            agent.speed = 6;
            sprite.color = new Color(255, 167, 0);
        }

        if (logic.playerScore == 3)
        {
            agent.speed = 61;
            agent.acceleration = 30;
            sprite.color = new Color(255, 0, 0); 
        }
    }

    void SetTargetPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        
    }
    void SetAgentPosition()
    {
        agent.SetDestination(new Vector3(target.x, target.y, transform.position.z));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.terminarJuego();
    }


}
