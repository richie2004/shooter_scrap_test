using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerdead : MonoBehaviour
{
 void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("target") )
        {
            SceneManager.LoadScene(0);
        }
    }

}
