using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	private Rigidbody rb;
	public Text gameover;
	public Text restarttext;
	Vector3 movement;
	public float startwait;
	public float restartwait;

	public static bool comp;
	private bool gameOver;
	private bool restart;
	private int i = 2;
	
	//public GameObject playerexplosion;

	// Use this for initialization
	void Start () {
		gameOver = false;
		restart = false;
		rb = GetComponent<Rigidbody> ();
		gameover.text = "";
		restarttext.text = " ";

		//yield return new WaitForSeconds (startwait);

			}
	void Awake(){
	

	}

	void Update ()
	{


		if (restart) {
			if (Input.touchCount >= 2) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
		  if (Input.GetKey (KeyCode.Escape)) {
		       if(Application.loadedLevelName == "Level")
				Application.Quit();
			   else 
				Application.LoadLevel("Level");
		}


	}
	

	void FixedUpdate() {
	   


		if (SystemInfo.deviceType == DeviceType.Desktop) {
			float movehor = Input.GetAxis ("Horizontal");
			float movever = Input.GetAxis ("Vertical");
			movement  = new Vector3 (movehor, movever, 0);
		} else {

			float movehor = Input.acceleration.x;
			float movever = Input.acceleration.y;
			movement  = new Vector3 (movehor, movever, 0);
		}

		rb.AddForce (movement * 3);

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary" && gameOver == false ) {

			//Instantiate(playerexplosion , transform.position , transform.rotation);
			gameover.text = "GAme over";
			restarttext.text = "Tap 2 Finger To Restart";
			restart = true;
			gameOver = true;
		    
		}
		else if (other.tag == "NextLevel") {
			 if(gameOver == false && other.tag == "Boundary")
			{
				restarttext.text = "Tap 2 Finger To Restart";
				restart= true;
			}

			  
			else{

				gameover.text ="YOU WON!!";
                gameOver = true;
				comp= true;

				StartCoroutine(MyLevel(0.5f,0));
             }
		}
	}

	IEnumerator MyLevel(float delay, int level)
	{
		yield return new WaitForSeconds(delay);
		Application.LoadLevel("Level");


	}



}
