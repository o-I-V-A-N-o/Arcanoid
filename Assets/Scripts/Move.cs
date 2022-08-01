using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5;
    Vector3 _direction;
    public Transform normal;
    public Transform vector;
    public Transform result;

    void Update()
    {
        Moove();
    }

    public void Moove()
    {
        //transform.position = Vector3.Reflect(originalObject.position, Vector3.forward);
        //Debug.Log(Vector3.Reflect(originalObject.position, Vector3.forward));
        //transform.position += transform.forward * speed * Time.deltaTime;


        result.position = Vector3.Reflect(vector.forward, normal.forward);
        
        Debug.DrawRay(normal.position, normal.forward * 10, Color.green);
        Debug.DrawRay(vector.position, vector.forward * 10, Color.red);
        Debug.DrawRay(normal.position, result.position, Color.blue);

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        _direction = Vector3.Reflect(originalObject.transform.position, transform.right);
        //transform.Rotate(_direction);
        Debug.Log(transform.position + " - " + collision.GetContact(0).normal + " - " + _direction);
        //transform.Rotate(_direction);
        transform.position = _direction;
    }*/
}
