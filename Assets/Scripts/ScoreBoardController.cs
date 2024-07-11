using System;
using TMPro;
using UnityEngine;

public class ScoreBoardController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _stepsLabel;

    [SerializeField] private TextMeshProUGUI _redPresentsLabel;
    [SerializeField] private TextMeshProUGUI _greenPresentsLabel;
    [SerializeField] private TextMeshProUGUI _bluePresentsLabel;

    [SerializeField] private UIGiftsColor _uiGiftsColor;
    
    private int _steps;
    private Color[] _colors;


    public void CountStep()
    {
        _steps++;
        _stepsLabel.text = _steps.ToString();
    }

    public void DecreaseGiftQuantity(Color color)
    {
        if (_uiGiftsColor.Colors[0] == color)
        {
            var quantity = Convert.ToInt32(_redPresentsLabel.text) - 1;
            _redPresentsLabel.text = quantity.ToString();
        }
        else if(_uiGiftsColor.Colors[1] == color)
        {
            var quantity = Convert.ToInt32(_greenPresentsLabel.text) - 1;
            _greenPresentsLabel.text = quantity.ToString();
        }
        else if(_uiGiftsColor.Colors[2] == color)
        {
            var quantity = Convert.ToInt32(_bluePresentsLabel.text) - 1;
            _bluePresentsLabel.text = quantity.ToString();
        }
    }

    public void SetColorsQuantity(Color color)
    {
        if (_uiGiftsColor.Colors[0] == color)
        {
            var quantity = Convert.ToInt32(_redPresentsLabel.text) + 1;
            _redPresentsLabel.text = quantity.ToString();
        }
        else if(_uiGiftsColor.Colors[1] == color)
        {
            var quantity = Convert.ToInt32(_greenPresentsLabel.text) + 1;
            _greenPresentsLabel.text = quantity.ToString();
        }
        else if(_uiGiftsColor.Colors[2] == color)
        {
            var quantity = Convert.ToInt32(_bluePresentsLabel.text) + 1;
            _bluePresentsLabel.text = quantity.ToString();
        }
    }
}