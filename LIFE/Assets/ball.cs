using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	private float speed;
	// Use this for initialization
	void Start () {
		float _s = Random.value;
		transform.localScale = new Vector3 (_s,_s,_s);
		gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (rdn(), 0, rdn()));
	}
	float rdn(){
		return (Random.value - 0.5f) * 20;
	}
	// Update is called once per frame
	void Update () {

	}
}
