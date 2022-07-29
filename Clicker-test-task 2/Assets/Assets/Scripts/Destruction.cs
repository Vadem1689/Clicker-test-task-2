using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class Destruction : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator animator;
    
    public bool a = false;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("object"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * speed, ForceMode.Impulse);

        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            a = true;
            collision.gameObject.GetComponent<Animator>().Play("Death");
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * speed, ForceMode.Impulse);


            Destroy(collision.gameObject, 1.7f);
            
        }


    }
    

    
    
}
