using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SinTextColor : MonoBehaviour {

	public float speed = 1.0f;
	public bool absolute;
	public Color targetColor = Color.white;

	private Text label;
	private Vector4 startColor;
	private Vector4 centerColor;
	private Vector4 colorRange;

	private void Start () {
		label = label ?? GetComponent<Text>();	// ?? => null合体演算子 
		startColor = label.color;
	}

	private void Update () {
		float sin = Mathf.Sin( Time.time * speed );
		centerColor = GetCenterColor( startColor, targetColor );
		Vector4 color = centerColor + ( colorRange * sin );
		label.color = color;
	}

	private Vector4 GetCenterColor (Vector4 start, Vector4 target) {
		Vector4 center = new Vector4 (
			(target.x + start.x) / 2,
			(target.y + start.y) / 2,
			(target.z + start.z) / 2,
			(target.w + start.w) / 2
		);
		colorRange = new Vector4 (
			Mathf.Abs(target.x - start.x) / 2,
			Mathf.Abs(target.y - start.y) / 2,
			Mathf.Abs(target.z - start.z) / 2,
			Mathf.Abs(target.w - start.w) / 2
		);
		return center;
	}
}
