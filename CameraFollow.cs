using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public float m_minFollowDistance;

    private Transform m_target;

    private float m_targetDistance;
    public float m_speed;

    void Start() {
        m_target = GetComponentInChildren<CameraLookAt>().m_lookAtTarget;
    }
	void Update () {
        m_targetDistance = Vector3.Distance(transform.position, m_target.transform.position);
        m_speed = m_targetDistance - m_minFollowDistance;

    }
    void FixedUpdate() {
        //if(m_targetDistance > m_minFollowDistance) {}
        transform.position = Vector3.MoveTowards(transform.position, m_target.position, m_speed);
    }
}
