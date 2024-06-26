using UnityEngine;

public class Candy : MonoBehaviour
{
    private Color _color;
    
    public void Initialize(ColorsProvider colorsProvider)
    {
        var color = colorsProvider.GetColor();
        GetComponentInChildren<Renderer>().material.color = color;
        _color = color;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Player>().SetHatColor(_color);

            Destroy(gameObject);
        }    
    }
}
