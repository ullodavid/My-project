using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public GameObject rock;
    private Rigidbody rb;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Carro")
        {
            if (rock != null)
            {
                rb = rock.GetComponent<Rigidbody>();
                rb.useGravity = true;
            }
        }
    }
}
