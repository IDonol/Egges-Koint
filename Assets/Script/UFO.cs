using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UFO : MonoBehaviour
{

    NavMeshAgent agent;
    [SerializeField] GameObject EndCube;
    [SerializeField] GameObject eg;

    [SerializeField] float d;
    [SerializeField] float qd;
    [SerializeField] bool ani ;
    [SerializeField] Animator anim;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //EndCube = GameObject.FindGameObjectWithTag("EndCube");
    }

    void Update()
    {
        if (ani)
        {
            agent.SetDestination(EndCube.transform.position);
        }
     
        if (GameM.flag)
        {

            EndCube = GameM.ciksas[Random.Range(0, GameM.j + 1)];
            ani = true;
        }
         
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("EndCube"))
        {
           
            //other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("EndCube"))
        {
            d = d + Time.deltaTime;
           

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("EndCube"))
        {
           
        }
    }
 
}

