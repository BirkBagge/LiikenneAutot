using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{


    public Transform player;
    public Vector3 offset;

    void Start()
    {

    }


    void Update()
    {   // offset että seura pelaajaa
        transform.position = player.position + offset;
    }


}
