using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AdditionProcess : MonoBehaviour
{
    private TextUpdaterLeft leftSide;
    private TextUpdaterRight rightSide;

    [SerializeField] private TMP_Text outText;

    private int leftResult = 0;
    private int rightResult = 0;
    private int sum = 0;

    void Start()
    {
        leftSide = GetComponent<TextUpdaterLeft>();
        rightSide = GetComponent<TextUpdaterRight>();
    }

    public void Addition()
    {
        leftResult = leftSide.UpdateWholeNumber();
        rightResult = rightSide.UpdateWholeNumber();

        sum = leftResult + rightResult;
        outText.text = $"{sum}";
    }

    public void NewExpression()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
