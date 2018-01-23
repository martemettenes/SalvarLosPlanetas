using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrampoline : MonoBehaviour {

    public float horizontalSpeed = 1;
    Vector2 input;

    public Transform rootTransform;


	void Update () {

        input = new Vector2(Input.GetAxis("Alt-Horizontal"), 0);

        if (input.x > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (input.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        rootTransform.Rotate(Vector3.forward, horizontalSpeed * -input.x * Time.deltaTime);

	}
}
