using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbounce : MonoBehaviour
{


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("boundary"))
        {
            {
                Destroy(gameObject);

            }
        }
    }
    
}
