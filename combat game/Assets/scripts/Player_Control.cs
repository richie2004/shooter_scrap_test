using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletprefab;
    private Controls ct;
    public float speed = 20f;
    Rigidbody rb;
    public Vector2 hor;
    private Vector2 key;
    Vector3 user;
    float bulletspeed = 5000;
    public float firerate = 0.1f;
    private float nextfire = 0.0f;
    private void Awake()
    {
        ct = new Controls();
    }
    private void OnEnable()
    {
        ct.Enable();
    }
    private void OnDisable()
    {
        ct.Disable();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        

    }
    void Update()
    {
        hor = ct.Shooter.move.ReadValue<Vector2>();
        key = ct.Shooter.shoot.ReadValue<Vector2>();
        user = GetComponent<Transform>().position;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(hor.x * speed , rb.velocity.y, 0);
        if (new Vector2 (0,0) != key && Time.time > nextfire)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        nextfire = Time.time + firerate;
        Vector3 attackpoint = new Vector3(user.x + (key.x*1.2f), user.y+ (key.y * 1.2f) , user.z);
        GameObject bulletcurrent = Instantiate(bulletprefab, attackpoint, Quaternion.identity);
        bulletcurrent.GetComponent<Rigidbody>().AddForce(key * bulletspeed);
        Destroy(bulletcurrent,1);
    }
}
