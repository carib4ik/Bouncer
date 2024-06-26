using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Color CurrentColor { get; private set; }

    public event Action HatColorChange;

    public void SetHatColor(Color color)
    {
        var renderers = transform.GetComponent<Renderer>();
        renderers.material.color = color;
        CurrentColor = color;

        HatColorChange?.Invoke();
    }
}