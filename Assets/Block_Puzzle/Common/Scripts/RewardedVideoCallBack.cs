﻿
using UnityEngine;

public class RewardedVideoCallBack : MonoBehaviour {

    private void Start()
    {
        Timer.Schedule(this, 0.1f, AddEvents);
    }

    private void AddEvents()
    {
    }

    private const string ACTION_NAME = "rewarded_video";
    //public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    //{
    //    int amount = ConfigController.Config.rewardedVideoAmount;
    //    CurrencyController.CreditBalance(amount);

    //    string unit = amount == 1 ? " ruby" : " rubies";
    //    Toast.instance.ShowMessage("You've received " + amount + unit, 3);
    //    CUtils.SetActionTime(ACTION_NAME);
    //}

    private void OnDestroy()
    {
    }
}
