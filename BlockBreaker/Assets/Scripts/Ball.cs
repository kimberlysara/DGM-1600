using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject paddle;
	private bool playing = false;
	public Vector3 paddleToBallVector; //Distance from ball to paddle
	private Rigidbody2D rigid;

	void Start () {
		playing = false;
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		if (!playing) {
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown(0)){
				print ("Click");
				rigid.velocity = new Vector2 (4,20);
				playing = true;
			}

		}
	}
}
