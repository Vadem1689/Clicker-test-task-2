using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject plaer;
    public float dist;
    NavMeshAgent nav;
    public float Radius=15;
   
    private Enemy enemy;
    Animator anim;
   
  
    public Destruction destruction;


    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        enemy = GetComponent<Enemy>();
        anim = GetComponent<Animator>();
    }
   
    private void Update()
    {
        if (destruction.a == true)
        {
            nav.enabled = false;
        }
        else
        {
            dist = Vector3.Distance(plaer.transform.position, transform.position);
            if (dist > Radius)
            {
                nav.enabled = false;
                anim.Play("Idle");
            }

            else if (dist < 2.2f)
            {
                anim.Play("Attack");
                nav.enabled = false;
            }
            else
            {
                nav.enabled = true;
                nav.SetDestination(plaer.transform.position);
                anim.Play("Run");
            }
        }
        
       
    }
    
}
