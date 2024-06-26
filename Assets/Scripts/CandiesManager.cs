using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class CandiesManager : MonoBehaviour
{
    [SerializeField] private Candy _candyPrefab;
    [SerializeField] private GiftsManager _gifts;

    public Candy CurrentCandy { get; private set; }
    
    public void Initialize(ColorsProvider colorsProvider)
    {
        CurrentCandy = Instantiate(_candyPrefab, transform);
        
        CurrentCandy.Initialize(colorsProvider);

        SetCandyPosition();
    }

    private void SetCandyPosition()
    {
        var candyPosition = CurrentCandy.transform.position;

        candyPosition.x = Random.Range(-8, 9);
        candyPosition.z = Random.Range(-8, 9);
        candyPosition.y = 0.1f;

        if (!IsPositionAvailable(candyPosition))
        {
            CurrentCandy.transform.position = candyPosition;
        }
        else
        {
            SetCandyPosition();
        }
    }

    private bool IsPositionAvailable(Vector3 position)
    {
        return _gifts.SpawnedPositions.Any(pos => Vector3.Distance(pos, position) < 2);
    }
}
