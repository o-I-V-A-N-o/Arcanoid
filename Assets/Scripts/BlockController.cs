using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        transform.gameObject.SetActive(false);
    }
}
