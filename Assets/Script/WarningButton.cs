using Script;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class WarningButton : MonoBehaviour
{
    private Button _button;
    
    private void Start()
    {
        _button = GetComponent<Button>();

        YandexAdsManager.Instance.OnAdvertisementLoad += CheckLoad;
        YandexAdsManager.Instance.OnAdvertisementShowed += OnAdsShowed;
        CheckLoad();
    }

    private void OnDestroy()
    {
        YandexAdsManager.Instance.OnAdvertisementLoad -= CheckLoad;
        YandexAdsManager.Instance.OnAdvertisementShowed -= OnAdsShowed;
    }

    private void OnAdsShowed(bool obj) => CheckLoad();

    private void CheckLoad()
    {
        _button.interactable = YandexAdsManager.Instance.IsLoaded;
    }
}