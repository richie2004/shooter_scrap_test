using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;


public class Spawner : MonoBehaviour
{

    public GameObject boxes;
    public float boxcount;
    private float currentboxes;
    Vector3 spawnerloca;
    private void Start()
    {
        spawnerloca = GetComponent<Transform>().position;
    }
    private void Update()
    {
        currentboxes = GameObject.FindGameObjectsWithTag("target").Length;
        boxcount = Mathf.Sqrt(Time.time);
        if (currentboxes < boxcount)
        {
            spawn();
        }
        
    }
    private void spawn()
    {
        GameObject newbox = Instantiate(boxes, new Vector3(Random.Range(-8, 40),Random.Range(25,30), spawnerloca.z), Quaternion.identity);
        newbox.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-15, 15), Random.Range(-15, 15), 0)*25);
        currentboxes ++;
    }

}
