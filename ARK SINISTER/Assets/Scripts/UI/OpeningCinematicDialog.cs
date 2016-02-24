using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpeningCinematicDialog : MonoBehaviour {

    public float TextSpeed = 1.0f;
    private int Index = 0;
    private ArrayList IntroScript = new ArrayList();
    public Text DialogText;
    private bool Active = false;

	// Use this for initialization
	void Start () {
        if (IntroScript == null) IntroScript = new ArrayList();
        if (IntroScript != null && IntroScript.Count != 0) IntroScript.Clear();
        if (IntroScript != null && IntroScript.Count == 0) AddScriptToList();

        ContinueButton_Click();
	}

    private void AddScriptToList()
    {
        IntroScript.Add("Earth, our home, is gone.");
        IntroScript.Add("Scorched by war, and then thrown into an eternal winter, we made our planet uninhabitable.");
        IntroScript.Add("The few survivors were able to construct a ship, a massive colony, with the sole purpose to leave Earth and find a new home.");
        IntroScript.Add("To live on. To survive...");
        IntroScript.Add("The journey could take hundreds of years.");
        IntroScript.Add("Those on board were put into cryo-sleep to ease the passage of time.");
        IntroScript.Add("But a ship this large needs maintenance.");
        IntroScript.Add("That's where you come in.");
        IntroScript.Add("You're an engineer, aren't you?");
        IntroScript.Add("Well, it's time to wake up then.");
        IntroScript.Add("Wake up! There's lots to do...");
    }

    public void ContinueButton_Click()
    {
        if (!Active)
        {
            DisplayString(IntroScript[Index].ToString());
            Index++;
        }
    }

    private void DisplayString(string Line)
    {
        Time.timeScale = TextSpeed;
        Active = true;
        foreach (char _c in Line.ToCharArray())
        {
            DialogText.text += _c.ToString();
        }
        Active = false;
    }

}
