using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Autot2 : MonoBehaviour
{
    public float speed = 5f;


    private void Start()
    {

    }

    private void Update()
    {   //Autot liikkuu
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {   //t�rm�yksess� vertaa tag ja tuhoaa jos oikea.
        if (collision.gameObject.CompareTag("Del"))
        {
            Destroy(this.gameObject);
        }
    }
}