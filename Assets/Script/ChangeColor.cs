using System.Globalization;
using UnityEngine;
using Random = UnityEngine.Random;


public class ChangeColor : MonoBehaviour
{
    private const string BackgroundKey = "BACKGROUND_KEY";
    
    public SpriteRenderer background;

    private void Start()
    {
        string defaultColor = $"#{ColorUtility.ToHtmlStringRGB(background.material.color)}";

        string colorStr = PlayerPrefs.GetString(BackgroundKey, defaultColor);

        if (!ColorUtility.TryParseHtmlString(colorStr, out Color color))
        {
            color = background.material.color;
            colorStr = $"#{ColorUtility.ToHtmlStringRGB(color)}";
        }

        background.material.color = color;
        PlayerPrefs.SetString(BackgroundKey, colorStr);
        PlayerPrefs.Save();
    }

    [ContextMenu(nameof(ChangeColorImage))]
    public void ChangeColorImage()
    {
        background.material.color = Random.ColorHSV();
        string colorStr = $"#{ColorUtility.ToHtmlStringRGB(background.material.color)}";
        
        PlayerPrefs.SetString(BackgroundKey, colorStr);
        PlayerPrefs.Save();
    }
}