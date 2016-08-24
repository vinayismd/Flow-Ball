using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class touchscript : MonoBehaviour {
	//public Text name;

	// Use this for initialization
	//Rect bound =  new Rect(Screen.width/2 - 50 , Screen.height/2 - 50 , Screen.width/2 + 50 , Screen.height/2   +50);
	void Start () {
		//name.text ="No";
	}
	
	// Update is called once per frame
	void Update () {



		if (Input.touchCount >= 1 || Input.GetMouseButtonDown (0)) {

			Vector2 pos = new Vector2(Input.mousePosition.x , Input.mousePosition.y);
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos) , Vector2.zero);

			if(hit.collider.name == "Play"){
				Application.LoadLevel("Level");

			}
		     else if(hit.collider.name == "Level1")
				{
					Application.LoadLevel("Main1");
				   
				}
				else if(hit.collider.name == "Level2")
				{
					Application.LoadLevel("Main2");
				}
				else if(hit.collider.name == "Level3")
				{
					Application.LoadLevel("Main3");
				}
				else if(hit.collider.name == "Level4")
				{
					Application.LoadLevel("Main4");
				}
				else if(hit.collider.name == "Level5")
				{
					Application.LoadLevel("Main5");
				}
				else if(hit.collider.name == "Level6")
				{
					Application.LoadLevel("Main6");
				}
				else if(hit.collider.name == "Level7")
				{
					Application.LoadLevel("Main7");
				}
				if(hit.collider.name == "Level8")
				{
					Application.LoadLevel("Main8");
				}
				else if(hit.collider.name == "Level9")
				{
					Application.LoadLevel("Main9");
				}
				else if(hit.collider.name == "Level10")
				{
					Application.LoadLevel("Main10");
				}
			}

		} 
	}

