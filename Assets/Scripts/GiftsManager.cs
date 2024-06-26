using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GiftsManager : MonoBehaviour
{
    [SerializeField] private Gift _giftPrefab;
    [SerializeField] private int _giftsCount = 6;

    private Gift _currentGift;
    private float _giftRadius = 1f;
    
    public List<Vector3> SpawnedPositions { get; private set; }

    
    public void Initialize(ColorsProvider colorsProvider)
    {
        SpawnedPositions = new List<Vector3>();
        
        for (var i = 0; i < _giftsCount; i++)
        {
            _currentGift = Instantiate(_giftPrefab, transform);
            
            SetGiftPosition();

            var color = colorsProvider.GetColor();
            _currentGift.Initialize(color);
        }
    }
    
    private void SetGiftPosition()
    {
        var giftPosition = _currentGift.transform.position;
        
        giftPosition.x = Random.Range(-8, 9);
        giftPosition.z = Random.Range(-8, 9);
        giftPosition.y = 0.1f;

        if (!IsPositionAvailable(giftPosition))
        {
            _currentGift.transform.position = giftPosition;
            SpawnedPositions.Add(_currentGift.transform.position);
        }
        else
        {
            SetGiftPosition();
        }
    }

    private bool IsPositionAvailable(Vector3 position)
    {
        return SpawnedPositions.Any(pos => Vector3.Distance(pos, position) < _giftRadius * 2);
    }
}