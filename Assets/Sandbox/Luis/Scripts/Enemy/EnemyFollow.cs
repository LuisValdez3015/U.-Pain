using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform jugador;
    [SerializeField] GameObject player;
    private Vector3 pPosition;
    Mecanica mecanica;
    public PickUpObj PickUpObj;
    MainMenu menu;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        mecanica = GetComponent<Mecanica>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        float dist = Vector3.Distance(gameObject.transform.position, jugador.position);
        if (dist<10)
        {
            agent.speed = agent.speed / 2;
            
        }
        
    }
    void OnTriggerEnter(Collider theCollision)
    {

        if (theCollision.tag == "Player")
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    void Move()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pPosition = player.transform.position;
        agent.SetDestination(pPosition);
    }
}
