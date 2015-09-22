using UnityEngine;
using System.Collections;

public class spawnExploding : MonoBehaviour {
	public GameObject explosion;
	public GameObject newBall;
	private float speed = 5f;
	private int numBall = 0;
	// Use this for initialization
	void Start () {
	
	}
	Vector3 rdnPosition(){
		return new Vector3 (Random.value * 12 - 6, 0, Random.value * 12 - 6);
	}
	// Update is called once per frame
	void Update () {
		if (Random.value < 0.004 && numBall<=20) {
			numBall++;
			Instantiate (newBall, rdnPosition(),transform.rotation);
		}

		if (Input.GetKey (KeyCode.A)) {
			Go(1);
		}
		if (Input.GetKey (KeyCode.D)) {
			Go(2);
		}
		if (Input.GetKey (KeyCode.W)) {
			Go(3);
		}
		if (Input.GetKey (KeyCode.S)) {
			Go(4);
		}

	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "bad")
		{
			explode();
		}
	}
	void Go(int d){
		switch (d) {
		case 1:
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (-speed, 0, 0));
			break;
		case 2:
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (speed, 0, 0));
			break;
		case 3:
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0,0, speed));
			break;
		case 4:
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0,-speed));
			break;
		}
	}
			

	void explode(){
		Instantiate (explosion, transform.position, transform.rotation);
		Destroy (gameObject);
	}

}
