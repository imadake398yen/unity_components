using UnityEngine;
using System.Collections;

public class SinPosition : MonoBehaviour {

	public float speed = 3.0f;
	public bool absolute;
	public Vector3 animationRange;
	private Vector3 startPosition;

	private void Start () {
		startPosition = transform.localPosition;
	}

	private void Update () {
		float sin = Mathf.Sin( Time.time * speed );
		if (absolute) sin = Mathf.Abs( sin );
		transform.localPosition = 
			startPosition + ( animationRange * sin );
	}

}
