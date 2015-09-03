
public calss LightTrigger: MonoBehavior{
	void Start(){
		Debug.Log("This is the start");	
	}
	
	void Update(){
	
	}
	
	void OnTriggerEnter(Collider other){
		Debug.Log("Trigger Start");
		gameObject.GetComponent<MeshRenderer>().material.
		
	}
}
		