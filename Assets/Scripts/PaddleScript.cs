using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	public float maxX;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal"); // poziome strzałki klawiatury

		if (x < 0) {
			MoveLeft ();
		}

		if (x > 0) {
			MoveRight ();
		}

		if (x == 0) {
			Stop ();
		}

		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp (pos.x,-maxX,maxX); // funkcja Clamp ogranicza pozycje pos.x do wartości - maxX i maxX 
		transform.position = pos;

	}

	void MoveLeft(){
		rb.velocity = new Vector2 (-speed,0);
	}

	void MoveRight(){
		
		rb.velocity = new Vector2 (speed,0);
	}

	void Stop(){
		rb.velocity = Vector2.zero;
	}


}
