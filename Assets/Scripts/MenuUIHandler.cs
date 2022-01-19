using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    //Load into the next scene
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    //Return to Main Menu
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Exit Application, including while in Editor
    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        //The button isn’t currently working because Application.Quit only works in the built application,
        Application.Quit(); //original code to quit Unity player
#endif
    }
}
