using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Hitdetecter : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="bullet" || other.gameObject.tag == "delete")
        {
            Destroy(gameObject);
        }
        else
        {
            rb.velocity = (rb .velocity - new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), 0))* -1 ;
        }
           
    }

}
