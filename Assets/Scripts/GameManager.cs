using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ColorsProvider _colorsProvider;
    [SerializeField] private GiftsManager _giftsManager;
    [SerializeField] private CandiesManager _candiesManager;
    [SerializeField] private Player _player;
    [SerializeField] private ScoreBoardController _scoreBoard;
    [SerializeField] private InputController _inputController;
    [SerializeField] private UIGiftsColor _uiGiftsColor;
    
    private void Awake()
    {
        _uiGiftsColor.SetUIColors(_colorsProvider.GetAllColors());
        _giftsManager.CountColors += _scoreBoard.SetColorsQuantity;
        _giftsManager.DestroyEvent += _scoreBoard.DecreaseGiftQuantity;
        _player.HatColorChange += SpawnNewCandy;
        _inputController.Steps += _scoreBoard.CountStep;
        
        _giftsManager.Initialize(_colorsProvider);
        _candiesManager.Initialize(_colorsProvider);
        
    }

    private void SpawnNewCandy()
    {
        _candiesManager.Initialize(_colorsProvider);
    }
}