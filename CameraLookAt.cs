using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {
    public Transform m_lookAtTarget;
    void Update () {
        transform.LookAt(m_lookAtTarget);
    }
}
