using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItems : MonoBehaviour 
{
	private int _degreesRotation = 60;

	private void Update()
	{
		transform.Rotate (0, _degreesRotation * Time.deltaTime, 0);
	}
}
