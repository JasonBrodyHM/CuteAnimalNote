using System;
using YandexMobileAds;
using YandexMobileAds.Base;

namespace Script
{
    public sealed class YandexAdsManager
    {
        private static readonly string _adUnitId = "R-M-2110309-1";
        
        private static YandexAdsManager _instance;

        public static YandexAdsManager Instance => _instance;
        
        public static void Initialize()
        {
            _instance = new YandexAdsManager();
        }

        private readonly RewardedAd _rewardedAd;

        private Action<bool> _adsCallback;

        public bool IsLoaded => _rewardedAd.IsLoaded();

        public event Action OnAdvertisementLoad;
        public event Action<bool> OnAdvertisementShowed;

        private YandexAdsManager()
        {
            _rewardedAd = new RewardedAd(_adUnitId);
            _rewardedAd.OnRewardedAdLoaded += HandleRewardedAdLoaded;
            _rewardedAd.OnRewardedAdFailedToLoad += HandleRewardedAdFailedToLoad;
            _rewardedAd.OnRewarded += HandleRewarded;
            _rewardedAd.OnRewardedAdFailedToShow += HandleRewardedAdFailedToShow;

            AdRequest adRequest = CreateRequest();
            _rewardedAd.LoadAd(adRequest);
        }

        public void ShowAdvertisement(Action<bool> callback)
        {
            if (IsLoaded)
            {
                _adsCallback = callback;
                _rewardedAd.Show();
            }
            else
            {
                callback?.Invoke(false);
            }
        }

        private void HandleRewardedAdLoaded(object sender, EventArgs eventArgs)
        {
            OnAdvertisementLoad?.Invoke();
        }
        
        private void HandleRewardedAdFailedToLoad(object sender, AdFailureEventArgs eventArgs)
        {
            AdRequest adRequest = CreateRequest();
            _rewardedAd.LoadAd(adRequest);
        }

        private void HandleRewarded(object sender, Reward reward)
        {
            Action<bool> callback = _adsCallback;
            _adsCallback = null;
            
            callback?.Invoke(true);
            
            AdRequest adRequest = CreateRequest();
            _rewardedAd.LoadAd(adRequest);
            
            OnAdvertisementShowed?.Invoke(true);
        }

        private void HandleRewardedAdFailedToShow(object sender, AdFailureEventArgs adFailureEventArgs)
        {
            Action<bool> callback = _adsCallback;
            _adsCallback = null;
            
            callback?.Invoke(false);
            
            AdRequest adRequest = CreateRequest();
            _rewardedAd.LoadAd(adRequest);
            
            OnAdvertisementShowed?.Invoke(false);
        }

        private static AdRequest CreateRequest()
        {
            var builder = new AdRequest.Builder();
            return builder.Build();
        }

    }
}