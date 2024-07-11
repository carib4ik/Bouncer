using UnityEngine;
using UnityEngine.UI;

public class UIGiftsColor : MonoBehaviour
{
    private Image[] _giftsImages;
    public Color[] Colors { get; private set; }

    private void Awake()
    {
        _giftsImages = GetComponentsInChildren<Image>();
    }

    public void SetUIColors(Color[] colors)
    {
        Colors = colors;
        
        // for (var i = 0; i < colors.Length; i++)
        // {
        //     _giftsImages[i + 1].color = colors[i];
        // }
    }
}
