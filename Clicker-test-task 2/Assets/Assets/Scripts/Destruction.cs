using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    [SerializeField] float speed;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ("object"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * speed, ForceMode.Impulse);
            
        }
        
    }
}
