using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame()
 {
     SceneManager.LoadScene("Map");   //permet de charger la scene "Map"
 }
    public void QuitGame()
 {
     Application.Quit();      // permet de quitter le jeu
      Debug.Log("EXIT GAME");
 }
     public void Credits()
    {
        SceneManager.LoadScene("Credits");    //permet de charger la scene "Credits"
    }
    public void Leave()  
    {
        SceneManager.LoadScene("Menu");  // permet de revenir dans la scène "Menu"
    }

}
