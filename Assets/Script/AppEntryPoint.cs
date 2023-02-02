using Script;
using UnityEngine;

public class AppEntryPoint
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void OnLoad()
    {
        Debug.Log("Initialization");

        YandexAdsManager.Initialize();
    }
}