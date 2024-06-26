using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ColorsProvider _colorsProvider;
    [SerializeField] private GiftsManager _giftsManager;
    [SerializeField] private CandiesManager _candiesManager;
    [SerializeField] private Player _player;

    private void Awake()
    {
        _giftsManager.Initialize(_colorsProvider);
        _candiesManager.Initialize(_colorsProvider);
    }

    private void Start()
    {
        _player.HatColorChange += SpawnNewCandy;
    }
    
    private void SpawnNewCandy()
    {
        _candiesManager.Initialize(_colorsProvider);
    }
}