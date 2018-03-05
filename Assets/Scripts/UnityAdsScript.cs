using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsScript : MonoBehaviour {


	/*public int totalCoins;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowAds()
	{
		Advertisement.Show("rewardedVideo", new ShowOptions() {resultCallback = HandleAdResult});
	}
	public void HandleAdResult(ShowResult result)
	{
		switch (result) {

		case ShowResult.Finished:
			totalCoins = PlayerPrefs.GetInt ("bankCoins");
			totalCoins = totalCoins + 150;
			PlayerPrefs.SetInt ("bankCoins", totalCoins);
			break;
		case ShowResult.Skipped:
			// not finished the ad
			break;

		case ShowResult.Failed:
			//no internet
			break;

		}
	}

	public void ShowAds2()
	{
		if (Advertisement.IsReady ()) {
			Advertisement.Show ("video", new ShowOptions () { resultCallback = HandleAdResult2 });
		}
	}
	public void HandleAdResult2(ShowResult result)
	{
		switch (result) {

		case ShowResult.Finished:
			totalCoins = PlayerPrefs.GetInt ("bankCoins");
			totalCoins = totalCoins + 100;
			PlayerPrefs.SetInt ("bankCoins", totalCoins);
			break;
		case ShowResult.Skipped:
			// not finished the ad
			break;

		case ShowResult.Failed:
			//no internet
			break;

		}
	}

*/
}
