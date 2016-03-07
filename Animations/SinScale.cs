using UnityEngine;
using System.Collections;

public class SinScale : MonoBehaviour {

	public float speed = 5.0f;
	public bool absolute;
	public bool preserveAspect;
	public Vector3 targetScale = new Vector3(1.0f, 1.0f, 1.0f);
	private Vector3 startScale;

	private void Start () {
		startScale = transform.localScale;
	}

	private void Update () {
		float sin = Mathf.Sin( Time.time * speed );
		if (absolute) sin = Mathf.Abs( sin );
		if (preserveAspect) targetScale = Vector3.one * targetScale.x; 
		transform.localScale =
			startScale + ( (targetScale - Vector3.one) * sin );
	}

}
