using UnityEngine;
using System.Collections;

public class finish : MonoBehaviour {
	private int x;
	public PlayerControl plyer;
	public SpriteRenderer fin1;
	// Use this for initialization
	void Start () {
		fin1 = GetComponent<SpriteRenderer> ();
		if (x != PlayerPrefs.GetInt("val"))
			fin1.enabled = false;
		else
			fin1.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	     if (PlayerControl.comp == true) {
		if(Application.loadedLevelName == "Main1")
			{  //  x = PlayerPrefs.SetInt("val", 1);
				fin1.enabled = true;
			}
		}
	}
	
}
