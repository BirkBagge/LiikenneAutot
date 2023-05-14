using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autot : MonoBehaviour
{
    public float speed = 5f;


    private void Start()
    {

    }

    private void Update()
    {   //Autot liikkuu
        transform.position += Vector3.forward * speed * Time.deltaTime;


    }
    void OnCollisionEnter(Collision collision)
    {   //törmäyksessä vertaa tag ja tuhoaa jos oikea.
        if (collision.gameObject.CompareTag("Del"))
        {
            Destroy(this.gameObject);
        }
    }
}

