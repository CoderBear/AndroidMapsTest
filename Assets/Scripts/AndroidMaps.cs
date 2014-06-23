using UnityEngine;
using System.Collections;

public class AndroidMaps : MonoBehaviour {

	public static AndroidJavaClass ViewJavaClass;

	// Use this for initialization
	void Start () {
		if(Application.platform == RuntimePlatform.Android) {
			// Initialize Android View
			ViewJavaClass = new AndroidJavaClass("com.tandosbs.maps.MapActivity");
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI() {
		if (GUI.Button(new Rect(20, 600, 300, 240), "Show android Screen")) {
			showMap();
		}
	}
	
	private void showMap() {
		AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject activity = unity.GetStatic<AndroidJavaObject>("currentActivity");
		activity.Call("showAndroidView");
	}
}