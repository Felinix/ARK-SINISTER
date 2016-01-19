using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShipStats : MonoBehaviour
{
    public Text ScrapText;
    public Text EnergyText;
    public Text LifeSptText;

    public float currentScrap;
    private float prevScrap;

    public float currentEnergy;
    private float prevEnergy;

    public float currentLifeSpt;
    private float prevLifeSpt;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if Scrap value has changed, update the value in the HUD and change the prev value.
        if (currentScrap != prevScrap && currentScrap >= 0 && currentScrap <= 999)
        {
            ChangeScrap();
            prevScrap = currentScrap;
        }
        // if Energy value has changed, update the value in the HUD and change the prev value.
        if (currentEnergy != prevEnergy && currentEnergy >= 0 && currentEnergy <= 999)
        {
            ChangeEnergy();
            prevEnergy = currentEnergy;
        }
        // if Life Support value has changed, update the value in the HUD and change the prev value.
        if (currentLifeSpt != prevLifeSpt && currentLifeSpt >= 0 && currentLifeSpt <= 999)
        {
            ChangeLifeSpt();
            prevLifeSpt = currentLifeSpt;
        }
    }

    private void ChangeScrap()
    {
        ScrapText.text = currentScrap.ToString();
    }

    private void ChangeEnergy()
    {
        EnergyText.text = currentEnergy.ToString();
    }

    private void ChangeLifeSpt()
    {
        LifeSptText.text = currentLifeSpt.ToString();
    }

}
