using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Del : MonoBehaviour
{
    public Transform player;
    public Vector3 ofset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   //laittaa offset toimimaan
        transform.position = player.position + ofset;


    }
    // Laittaa menu nappulan toimimaan.
    public void Menu()
    {

        SceneManager.LoadScene("MainMenu");
    }

}
