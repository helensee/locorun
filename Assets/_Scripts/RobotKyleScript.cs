using UnityEngine;
using System.Collections;

public class RobotKyleScript : MonoBehaviour {

	public float rotateSpeed;
	public float speed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		// turn/rotate
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			//transform.Rotate (0, 0, Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime);
			transform.Rotate(0, rotateSpeed, 0);
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0, -rotateSpeed, 0);
		}
		// walk
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			transform.position += (Vector3.Cross(transform.right.normalized, transform.up.normalized)) * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			transform.position += (-1 * (Vector3.Cross(transform.right.normalized, transform.up.normalized))) * speed * Time.deltaTime;
		}
		// run
		if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W))) {
			transform.position += (Vector3.Cross(transform.right.normalized, transform.up.normalized)) * 5 * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S))) {
			transform.position += (-1 * (Vector3.Cross(transform.right.normalized, transform.up.normalized))) * 5 * speed * Time.deltaTime;
		}
	}
}
