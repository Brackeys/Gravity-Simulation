using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
public class Body : MonoBehaviour {
	
	private const float GRAVITY_CONST = 600;

	public static List<Body> Bodies;
	
	public Rigidbody rb { get; protected set; }

	// Use this for initialization
	void Start () {
		if (Bodies == null)
			Bodies = new List<Body>();
			
		Bodies.Add (this);
		
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		foreach (Body _body in Bodies) {
			if (_body == this)
				continue;
			
			float m1 = rb.mass;
			float m2 = _body.rb.mass;
			
			float r = Vector3.Distance (transform.position, _body.transform.position);
			
			float F_amp = (m1 * m2) / Mathf.Pow (r, 2);
			F_amp *= GRAVITY_CONST;
			
			Vector3 dir = Vector3.Normalize (_body.transform.position - transform.position);
			
			Vector3 F = (dir * F_amp) * Time.fixedDeltaTime;
			//Debug.Log ("Force: " + F);
			rb.AddForce (F);
			
		}
	}
}
