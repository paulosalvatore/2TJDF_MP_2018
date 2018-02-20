using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestesInput : MonoBehaviour
{
	private void Update()
	{
		// int quantidadeToques = Input.touchCount;
		// Debug.Log(quantidadeToques);

		/*
		transform.Translate(
			Input.acceleration.x,
			0,
			-Input.acceleration.z
		);
		*/

		Debug.Log(
			string.Format(
				"X: {0}, Y: {1}, Z: {2}",
				Input.acceleration.x,
				Input.acceleration.y,
				Input.acceleration.z
			)
		);

		/*if (Input.touchCount > 0)
		{
			Touch toque = Input.GetTouch(0);

			Debug.Log(
				string.Format(
					"X: {0}, Y: {1}",
					toque.position.x,
					toque.position.y
				)
			);
		}*/
	}
}
