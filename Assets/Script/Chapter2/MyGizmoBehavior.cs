using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmoBehavior : MonoBehaviour {

	public float m_offset;

	private void OnDrawGizmos()
	{
		// Color Gizmo modification
		Gizmos.color = Color.blue;
		//m_offset = 0.2f;
		// Position of the center for the 3 axes
		m_positionX = new Vector3(-(transform.localPosition.x + (transform.localScale.x / 2) + m_offset), transform.localPosition.y, transform.localPosition.z);
		m_positionY = new Vector3(transform.localPosition.x, -(transform.localPosition.y + (transform.localScale.y / 2) + m_offset), transform.localPosition.z);
		m_positionZ = new Vector3(transform.localPosition.x, transform.localPosition.y, -(transform.localPosition.z + (transform.localScale.z / 2) + m_offset));

		// sphere display
		Gizmos.DrawSphere(m_positionX, transform.localScale.x / 10);
		Gizmos.DrawSphere(m_positionY, transform.localScale.y / 10);
		Gizmos.DrawSphere(m_positionZ, transform.localScale.z / 10);

		// Line display
		Gizmos.DrawLine(transform.localPosition, m_positionX);
		Gizmos.DrawLine(transform.localPosition, m_positionY);
		Gizmos.DrawLine(transform.localPosition, m_positionZ);
	}

	private Vector3 m_positionX;
	private Vector3 m_positionY;
	private Vector3 m_positionZ;
	
}
