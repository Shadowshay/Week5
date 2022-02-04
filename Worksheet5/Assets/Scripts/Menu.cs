using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void onClick_SinglePlayer()
    {
        Debug.Log("Loading Single Player");
        SceneManager.LoadScene("SinglePlayer");
    }
    public void onClick_Multiplayer()
    {
        Debug.Log("Loading Multiplayer");
        SceneManager.LoadScene("MultiPlayerLauncher");
    }
}
