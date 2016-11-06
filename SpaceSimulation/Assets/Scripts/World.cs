using UnityEngine;

public class World : MonoBehaviour {

	public void ChangeTime (float _speed) {
		Time.timeScale = _speed;
		//Time.fixedDeltaTime = 0.02F * Time.timeScale;
	}
	
}
