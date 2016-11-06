using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public GameObject obj;

	public float spawnRate = 2f;
	
	public float forceMultiplier = 1f;

	void Start () {
		
		StartCoroutine(Spawn());
		
	}
	
	IEnumerator Spawn () {
		GameObject _go = (GameObject)Instantiate (obj, transform.position, transform.rotation);
		
		Rigidbody _rb = _go.GetComponent<Rigidbody>();
		if (_rb != null) {
			//_rb.AddForce (transform.forward * forceMultiplier, ForceMode.Impulse);
		
			_rb.AddForce (Random.onUnitSphere * Random.Range (forceMultiplier/3f, forceMultiplier), ForceMode.Impulse);
		}
		
		yield return new WaitForSeconds (1f/spawnRate);
		StartCoroutine(Spawn());
	}
	
}
