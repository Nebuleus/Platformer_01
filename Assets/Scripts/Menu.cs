using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame()
 {
     SceneManager.LoadScene("Map");
 }
    public void QuitGame()
 {
     Application.Quit();
      Debug.Log("EXIT GAME");
 }
     public void Credits()
    {
        SceneManager.LoadScene("Credits");    //permet de charger la scene "Credits"
    }
    public void Leave()
    {
        SceneManager.LoadScene("Menu");
    }

}
