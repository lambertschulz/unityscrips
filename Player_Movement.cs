using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public float m_speed;

    public float m_horizontal;
    public float m_vertical;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
    void Update() {
        m_vertical = Input.GetAxis("Vertical");     // Up and Down
        m_horizontal = Input.GetAxis("Horizontal"); // Left and Right
    }


	void FixedUpdate () {
        gameObject.transform.position += new Vector3(m_vertical*m_speed, 0f, m_horizontal*m_speed);
        //gameObject.transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal"), 0f));
    }
}
