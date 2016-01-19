using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour {

    public Image HPFore;
    public Image ENFore;
    public Image SHFore;

    public float currentHP;
    private float prevHP;
    public float maxHP;

    public float currentEN;
    private float prevEN;
    public float maxEN;

    public float currentSH;
    private float prevSH;
    public float maxSH;

 	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // if HP has changed, call ChangeHP() and update prevHP variable.
        if (currentHP != prevHP && currentHP >= 0 && currentHP <= maxHP)
        {
            ChangeHP();
            prevHP = currentHP;
        }
        // if EN has changed, call ChangeEN() and update prevEN variable.
        if (currentEN != prevEN && currentEN >= 0 && currentEN <= maxEN)
        {
            ChangeEN();
            prevEN = currentEN;
        }
        // if SH has changed, call ChangeSH() and update prevSH variable.
        if (currentSH != prevSH && currentSH >= 0 && currentSH <= maxSH)
        {
            ChangeSH();
            prevSH = currentSH;
        }
    }

    public void ChangeHP()
    {       
        HPFore.rectTransform.sizeDelta = new Vector2((int)(80 * (currentHP / maxHP)), 10);
        if (currentHP / maxHP > 0.7)
        {
            HPFore.color = Color.green;
        }
        else if (currentHP / maxHP <= 0.7 && currentHP / maxHP > 0.3)
        {
            HPFore.color = Color.yellow;
        }
        else
        {
            HPFore.color = Color.red;
        }
    }

    private void ChangeEN()
    {
        ENFore.rectTransform.sizeDelta = new Vector2((int)(80 * (currentEN / maxEN)), 10);
    }

    private void ChangeSH()
    {
        SHFore.rectTransform.sizeDelta = new Vector2((int)(80 * (currentSH / maxSH)), 10);
    }
}
