using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WW1 : MonoBehaviour
{

    NavMeshAgent agent;
    [SerializeField] GameObject EndCube;
    [SerializeField] GameObject eg;

    [SerializeField] float d;
    [SerializeField] float qd;
    [SerializeField] bool ani = true;
    [SerializeField] Animator anim;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
       // EndCube = GameObject.FindGameObjectWithTag("EndCube");
    }

    void Update()
    {
        agent.SetDestination(EndCube.transform.position);
        anim.SetBool("Walk", ani);
        eggs();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndCube"))
        {
            ani = false;
            anim.SetBool("Turn Head", true);
            //other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("EndCube"))
        {
            d = d + Time.deltaTime;
            if (d >= 3)
            {
                anim.SetBool("Eat", true);
                anim.SetBool("Turn Head", false);
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("EndCube"))
        {
            ani = true;
            anim.SetBool("Eat", false);
        }
    }
    private void eggs()
    {
        qd = qd + Time.deltaTime;
        if (qd >= 5)
        {
            eg.SetActive(true);
            qd = 0;
        }
    }
}
