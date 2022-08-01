using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 1f;
    public bool hover = false;
    public Vector3 _direction;

    public Transform originalObject;
    public Transform reflectedObject;


    // Start is called before the first frame update
    void Start()
    {
        _direction = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _direction = Vector3.Reflect(transform.forward, collision.GetContact(0).normal);

        transform.forward = _direction;
    }
}
