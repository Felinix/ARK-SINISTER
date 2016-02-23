using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public static void StartGame_Click()
    {
        SceneManager.LoadScene("StartGame");
    }

    public static void ContinueGame_Click()
    {
        // load game state from "previously played" database table.
    }

    public static void Options_Click()
    {
        // show options menu
    }

    public static void About_Click()
    {
        // show about menu
    }

    public static void Quit_Click()
    {
        // Exit game.
        Application.Quit();
    }
}
