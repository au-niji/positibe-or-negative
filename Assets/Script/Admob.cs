using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Admob : MonoBehaviour
{
    private BannerView bannerView;
    public void Start()
    {
        #if UNITY_ANDROID
            string appId = "ca-app-pub-xxxxxxxxxxxxxxxx~xxxxxxxxxx"; // xを新しい広告IDに置き換える(アプリを指定するためのID)
        #elif UNITY_IPHONE
            string appId = "ca-app-pub-xxxxxxxxxxxxxxxx~xxxxxxxxxx"; // xを新しい広告IDに置き換える(アプリを指定するためのID)
        #else
            string appId = "unexpected_platform";
        #endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        this.RequestBanner();
    }

    private void RequestBanner()
    {
        //depelopment build の場合はテスト広告を使用する。
        #if UNITY_ANDROID
            string adUnitId = Debug.isDebugBuild ? "ca-app-pub-xxxxxxxxxxxxxxxx/xxxxxxxxxx" : "ca-app-pub-xxxxxxxxxxxxxxxx/xxxxxxxxxx"; // xを新しい広告IDに置き換える(広告の表示される場所などを指定するID)
        #elif UNITY_IPHONE
            string adUnitId = Debug.isDebugBuild ? "ca-app-pub-xxxxxxxxxxxxxxxx/xxxxxxxxxx" : "ca-app-pub-xxxxxxxxxxxxxxxx/xxxxxxxxxx"; // xを新しい広告IDに置き換える(広告の表示される場所などを指定するID)
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

    public void HideBanner()
    {
        bannerView.Hide();
    }

    public void ShowBanner()
    {
        bannerView.Show();
    }
}