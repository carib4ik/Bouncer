using System;
using TMPro;
using UnityEngine;

public class ScoreBoardController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _stepsLabel;
    [SerializeField] private TextMeshProUGUI _redPresentsLabel;
    [SerializeField] private TextMeshProUGUI _greenPresentsLabel;
    [SerializeField] private TextMeshProUGUI _bluePresentsLabel;
    
    private int _steps;

    public void CountStep()
    {
        _steps++;
        _stepsLabel.text = _steps.ToString();
    }

    public void DecreaseQuantity(TextMeshProUGUI presentLabel)
    {
        var quantity = Convert.ToInt32(presentLabel.text);
        quantity--;
        presentLabel.text = quantity.ToString();

    }
}
