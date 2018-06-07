using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastAd : MonoBehaviour
{
    public static BlastAd instance;
    public float displayTime = 3f;
    public Transform exitButton;
    public Transform adPanel;
    public bool isRewardedAd;
    private float timeCounter;
    private bool isShowingAd;
    // Use this for initialization
    private void Awake()
    {
        instance = this;
    }

    void Start ()
    {        
        ShowBlastAd();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(isShowingAd)
        {
            timeCounter += Time.deltaTime;
            if(timeCounter >= displayTime)
            {
                exitButton.gameObject.SetActive(true);
                isShowingAd = false;
            }
        }
        
	}
    public void ShowBlastAd()
    {
        adPanel.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(false);
        timeCounter = 0;
        isShowingAd = true;
    }

    public void HideBlastAd()
    {
        adPanel.gameObject.SetActive(false);
        if(isRewardedAd) Toast.instance.ShowMessage("You've received 2 rubies", 3);
        isRewardedAd = false;
    }

    public void OpenURL()
    {
        Application.OpenURL("https://app.adjust.com/m24ohje");
    }
}
