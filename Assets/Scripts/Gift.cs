using System;
using UnityEngine;

public class Gift : MonoBehaviour
{
    private Player _player;
    private Color _color;
    private Collider _collider;
    
    public void Initialize(Color color)
    {
        var lid = transform.Find("lid");
        var materials = lid.GetComponent<Renderer>().materials;
        materials[1].color = color;
        lid.GetComponent<Renderer>().materials = materials;

        _color = color;
    }

    private void Start()
    {
        _collider = GetComponent<Collider>();

        _player = FindObjectOfType<Player>();

        _player.HatColorChange += SwitchKineticMode;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _player.HatColorChange -= SwitchKineticMode;
            Destroy(gameObject);
        } 
    }

    private void SwitchKineticMode()
    {
        _collider.isTrigger = _player.CurrentColor == _color;
    }
}