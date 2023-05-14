using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{   //menu nappula toimintaan
    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}


