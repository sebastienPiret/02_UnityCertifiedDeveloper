using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySimpleItem : MonoBehaviour {

	public int m_xpPerEnemyKilled;
	public int m_enemiesKilled;
	public int m_experience
	{
		get { return m_enemiesKilled * m_xpPerEnemyKilled; }
	}
}
