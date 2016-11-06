using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StartForce : MonoBehaviour {

	[SerializeField]
	Vector3 force;

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
		
		rb.AddForce (force, ForceMode.Impulse);
	}
	
}
