using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdaterRight : MonoBehaviour
{
    [SerializeField] private TMP_Text hundredsText;
    [SerializeField] private TMP_Text tensText;
    [SerializeField] private TMP_Text unitsText;

    [SerializeField] private GameObject[] hundredsImage;
    [SerializeField] private GameObject[] tensImage;
    [SerializeField] private GameObject[] unitsImage;

    private int hundreds = 1;
    private int tens = 1;
    private int units = 1;

    void Start()
    {
        UpdateDisplay();
        UpdateImageHundreds(hundreds);
        UpdateImageTens(tens);
        UpdatImageUnits(units);
    }

    void UpdateDisplay()
    {
        hundredsText.text = hundreds.ToString();
        tensText.text = tens.ToString();
        unitsText.text = units.ToString();
    }

    public void UpdateImageHundreds(int index)
    {
        for (int i = 1; i <= hundredsImage.Length; i++)
        {
            if (i == index)
            {
                hundredsImage[i].SetActive(true);
            }
            if (i != index)
            {
                hundredsImage[i].SetActive(false);
            }
        }
    }

    public void UpdateImageTens(int index)
    {
        for (int i = 1; i <= tensImage.Length; i++)
        {
            if (i == index)
            {
                tensImage[i].SetActive(true);
            }
            if (i != index)
            {
                tensImage[i].SetActive(false);
            }
        }
    }

    public void UpdatImageUnits(int index)
    {
        for (int i = 1; i <= unitsImage.Length; i++)
        {
            if (i == index)
            {
                unitsImage[i].SetActive(true);
            }
            if (i != index)
            {
                unitsImage[i].SetActive(false);
            }
        }
    }

    public void IncreaseHundredValue()
    {
        hundreds = Mathf.Clamp(hundreds + 1, 1, 9);
        UpdateDisplay();
        UpdateImageHundreds(hundreds);
    }

    public void DecreaseHundredValue()
    {
        hundreds = Mathf.Clamp(hundreds - 1, 1, 9);
        UpdateDisplay();
        UpdateImageHundreds(hundreds);
    }

    public void IncreaseTensValue()
    {
        tens = Mathf.Clamp(tens + 1, 1, 9);
        UpdateDisplay();
        UpdateImageTens(tens);
    }

    public void DecreaseTensValue()
    {
        tens = Mathf.Clamp(tens - 1, 1, 9);
        UpdateDisplay();
        UpdateImageTens(tens);
    }

    public void IncreaseUnitsValue()
    {
        units = Mathf.Clamp(units + 1, 1, 9);
        UpdateDisplay();
        UpdatImageUnits(units);
    }

    public void DecreaseUnitsValue()
    {
        units = Mathf.Clamp(units - 1, 1, 9);
        UpdateDisplay();
        UpdatImageUnits(units);
    }

    public int UpdateWholeNumber()
    {
        int result = hundreds * 100 + tens * 10 + units;
        return result;
    }
}
