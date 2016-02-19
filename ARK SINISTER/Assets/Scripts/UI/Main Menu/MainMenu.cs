using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public static void StartGame_Click()
    {
        Application.LoadLevel("StartGame");
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
