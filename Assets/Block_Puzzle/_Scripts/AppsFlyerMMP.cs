using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppsFlyerMMP : MonoBehaviour {

    void Start()
    {
        // For detailed logging
        //AppsFlyer.setIsDebug (true);
        AppsFlyer.setAppsFlyerKey("aTYJZVwsYCTz8BbnbrDbxL");
#if UNITY_IOS
        //Mandatory - set your AppsFlyer’s Developer key.
        
        //Mandatory - set your apple app ID
        //NOTE: You should enter the number only and not the "ID" prefix
        AppsFlyer.setAppID ("YOUR_APP_ID_HERE");
        AppsFlyer.trackAppLaunch ();
#elif UNITY_ANDROID
        //Mandatory - set your Android package name
        AppsFlyer.setAppID("////");
        //Mandatory - set your AppsFlyer’s Developer key.
        AppsFlyer.init("aTYJZVwsYCTz8BbnbrDbxL", "AppsFlyerTrackerCallbacks");

        //For getting the conversion data in Android, you need to this listener.
        //AppsFlyer.loadConversionData("AppsFlyerTrackerCallbacks");

#endif
    }

    public static void LevelCompleted()
    {
        Dictionary<string, string> levelCompleted = new Dictionary<string, string>();
        levelCompleted.Add("count", "1");
        AppsFlyer.trackRichEvent("level_completed", levelCompleted);
        Debug.Log("AppsFlyerMMP: Level Completed");
    }
    public static void ChallengeModeBeginnerCompleted()
    {
        Dictionary<string, string> challengeModeBeginnerCompleted = new Dictionary<string, string>();
        challengeModeBeginnerCompleted.Add("count", "1");
        AppsFlyer.trackRichEvent("beginner_challenge_mode_completed", challengeModeBeginnerCompleted);
        Debug.Log("AppsFlyerMMP: Challenge Mode Beginner Completed");
    }
    public static void ChallengeModeAdvancedCompleted()
    {
        Dictionary<string, string> challengeModeAdvancedCompleted = new Dictionary<string, string>();
        challengeModeAdvancedCompleted.Add("count", "1");
        AppsFlyer.trackRichEvent("advanced_challenge_mode_completed", challengeModeAdvancedCompleted);
        Debug.Log("AppsFlyerMMP: Challenge Mode Advanced Completed");
    }
    public static void ChallengeModeMasterCompleted()
    {
        Dictionary<string, string> challengeModeMasterCompleted = new Dictionary<string, string>();
        challengeModeMasterCompleted.Add("count", "1");
        AppsFlyer.trackRichEvent("master_challenge_mode_completed", challengeModeMasterCompleted);
        Debug.Log("AppsFlyerMMP: Challenge Mode Master Completed");
    }
    public static void ChallengeModeExpertCompleted()
    {
        Dictionary<string, string> challengeModeExpertCompleted = new Dictionary<string, string>();
        challengeModeExpertCompleted.Add("count", "1");
        AppsFlyer.trackRichEvent("expert_challenge_mode_completed", challengeModeExpertCompleted);
        Debug.Log("AppsFlyerMMP: Challenge Mode Expert Completed");
    }
    public static void UnlockedAdvancedChallengeMode()
    {
        Dictionary<string, string> unlockedAdvancedChallengeMode = new Dictionary<string, string>();
        unlockedAdvancedChallengeMode.Add("count", "1");
        AppsFlyer.trackRichEvent("unlocked_advanced", unlockedAdvancedChallengeMode);
        Debug.Log("AppsFlyerMMP: Unlocked Advanced Challenge Mode");
    }
    public static void UnlockedMasterChallengeMode()
    {
        Dictionary<string, string> unlockedMasterChallengeMode = new Dictionary<string, string>();
        unlockedMasterChallengeMode.Add("count", "1");
        AppsFlyer.trackRichEvent("unlocked_master", unlockedMasterChallengeMode);
        Debug.Log("AppsFlyerMMP: Unlocked Master Challenge Mode");
    }
    public static void UnlockedExpertChallengeMode()
    {
        Dictionary<string, string> unlockedExpertChallengeMode = new Dictionary<string, string>();
        unlockedExpertChallengeMode.Add("count", "1");
        AppsFlyer.trackRichEvent("unlocked_expert", unlockedExpertChallengeMode);
        Debug.Log("AppsFlyerMMP: Unlocked Expert Challenge Mode");
    }
    public static void Stars(int count)
    {
        Dictionary<string, string> stars = new Dictionary<string, string>();
        stars.Add("count", count.ToString());
        AppsFlyer.trackRichEvent("stars", stars);
        Debug.Log("AppsFlyerMMP: Stars: " + count);
    }

    public static void LineClearedCount(int count)
    {
        Dictionary<string, string> lineClearedCount = new Dictionary<string, string>();
        lineClearedCount.Add("count", count.ToString());
        if(count == 1)
        {
            AppsFlyer.trackRichEvent("line_cleared_1", lineClearedCount);
            Debug.Log("AppsFlyerMMP: Cleared 1 Line");
        }            
        else if (count == 2)
        {
            AppsFlyer.trackRichEvent("line_cleared_2", lineClearedCount);
            Debug.Log("AppsFlyerMMP: Cleared 2 Lines");
        }
        else if (count == 3)
        {
            AppsFlyer.trackRichEvent("line_cleared_3", lineClearedCount);
            Debug.Log("AppsFlyerMMP: Cleared 3 Lines");
        }
        else if (count == 4)
        {
            AppsFlyer.trackRichEvent("line_cleared_4", lineClearedCount);
            Debug.Log("AppsFlyerMMP: Cleared 4 Lines");
        }

    }
    public static void Score(int score)
    {
        Dictionary<string, string> playerScore = new Dictionary<string, string>();
        playerScore.Add("count", score.ToString());
        AppsFlyer.trackRichEvent("score", playerScore);
        Debug.Log("AppsFlyerMMP: Score - " + score);
    }
    public static void InAppPurchase20Rubies()
    {
        Dictionary<string, string> purchaseEvent = new Dictionary<string, string>();
        purchaseEvent.Add("af_currency", "USD");
        purchaseEvent.Add("af_revenue", "0.99");
        purchaseEvent.Add("af_quantity", "1");
        AppsFlyer.trackRichEvent("iap_20rubies", purchaseEvent);
        Debug.Log("AppsFlyerMMP: 20 Rubies IAP");
    }
    public static void InAppPurchase50Rubies()
    {
        Dictionary<string, string> purchaseEvent = new Dictionary<string, string>();
        purchaseEvent.Add("af_currency", "USD");
        purchaseEvent.Add("af_revenue", "1.99");
        purchaseEvent.Add("af_quantity", "1");
        AppsFlyer.trackRichEvent("iap_50rubies", purchaseEvent);
        Debug.Log("AppsFlyerMMP: 50 Rubies IAP");
    }
    public static void InAppPurchase120Rubies()
    {
        Dictionary<string, string> purchaseEvent = new Dictionary<string, string>();
        purchaseEvent.Add("af_currency", "USD");
        purchaseEvent.Add("af_revenue", "3.99");
        purchaseEvent.Add("af_quantity", "1");
        AppsFlyer.trackRichEvent("iap_120rubies", purchaseEvent);
        Debug.Log("AppsFlyerMMP: 120 Rubies IAP");
    }
    public static void InAppPurchase200Rubies()
    {
        Dictionary<string, string> purchaseEvent = new Dictionary<string, string>();
        purchaseEvent.Add("af_currency", "USD");
        purchaseEvent.Add("af_revenue", "5.99");
        purchaseEvent.Add("af_quantity", "1");
        AppsFlyer.trackRichEvent("iap_200rubies", purchaseEvent);
        Debug.Log("AppsFlyerMMP: 200 Rubies IAP");
    }
}