using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float speed = 5f;
    private float targetTime;


    void Start()
    {

    }
    void Update()
    {   // asettaa arvot mink� v�liin voi spawnata
        targetTime -= Time.deltaTime;
        if (targetTime <= 0)
        {
            SpawnObject();
            targetTime = Random.Range(4, 8);

        }

        // lis�� liikkeen
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
    public void SpawnObject() // spawnaa objectin ja asettaa suunnan
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}