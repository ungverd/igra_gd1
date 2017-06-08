using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScroll : MonoBehaviour {

    public float coefficient = 5;
	
	void Update () {
        transform.Translate(Vector3.left * coefficient * Input.GetAxis("Mouse ScrollWheel"));
	}
}
