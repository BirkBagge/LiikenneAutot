using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public float Turn = 1;

    public float jarru = 1f;

    void Start()
    {

    }


    private void Update()
    {   // asettaa nopeuden eteenpäin
        transform.position += Vector3.forward * speed * Time.deltaTime;

        // vasemmalle ja oikealle kun painetaan a ja d
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * Turn * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * Turn * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }


    void OnCollisionEnter(Collision collision)
    {   //törmäyksessä vertaa tag ja laittaa päälle "restart"
        if (collision.gameObject.CompareTag("Auto"))
        {
            Invoke("Restart", 1f);

        }

    }
    void Restart()
    {   //lataa scenen uudelleen
        SceneManager.LoadScene("SampleScene");
    }
}
