using UnityEngine;
 
public class CameraRotate : MonoBehaviour {
   
    public Transform target;
    public float speedMod = 0.1f;
    private Vector3 point;
   
    void Update () {
        point = target.position;
        transform.LookAt(point);
		
		transform.RotateAround (point,new Vector3(0.0f,1.0f,0.0f),20 * Time.deltaTime * speedMod);
    }
}