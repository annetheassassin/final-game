using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Moneyui : MonoBehaviour
{
    public Text moneyText;
    void Update()
    {
        moneyText.text = PlayerStats.Money.ToString();
    }
}
