using UnityEngine;
using System.Collections;

public class FollowMouseCurser : MonoBehaviour {
    RaycastHit hit;
    Ray ray;

	void Update () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit)) {
            transform.position = hit.transform.position;
        }
	}
}
