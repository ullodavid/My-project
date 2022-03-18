using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Carro")
        {

            Debug.Log("Game Over");
            SceneManager.LoadScene("Escena 1");
        }
    }
}
