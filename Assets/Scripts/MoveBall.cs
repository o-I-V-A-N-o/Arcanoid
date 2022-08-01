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
        
        if (hover)
        {
            speed *= -1f;
            hover = false;
            transform.Rotate(reflectedObject.position);
        }
        transform.position += _direction * speed * Time.deltaTime;

        //Debug.DrawRay(transform.position, transform.forward*10, Color.red);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        _direction = Vector3.Reflect(transform.forward, collision.transform.forward);
        Debug.Log(_direction + " - " + collision.GetContact(0).normal);
        transform.Rotate(_direction * 50f);
    }
}
