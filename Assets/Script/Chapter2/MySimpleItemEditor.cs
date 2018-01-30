using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MySimpleItem))]
public class MySimpleItemEditor : Editor {

	public override void OnInspectorGUI()
	{
		// Displays default property
		DrawDefaultInspector();

		MySimpleItem myTarget = (MySimpleItem)target;
		EditorGUILayout.LabelField("Experience", string.Format("{0} xp", myTarget.m_experience));

		// begin horizontal group for buttons
		EditorGUILayout.BeginHorizontal();

		// Decrease xp by ten
		if(GUILayout.Button("- 10"))
		{
			myTarget.m_xpPerEnemyKilled -= 10;
			// if result <0, forced to zero
			//if (myTarget.m_xpPerEnemyKilled < 0) myTarget.m_xpPerEnemyKilled = 0;
		}
		// increase xp by ten
		if(GUILayout.Button("+ 10"))
		{
			myTarget.m_xpPerEnemyKilled += 10;
		}

		// Ending horizontal group
		EditorGUILayout.EndHorizontal();

		// if xp goes under zero -> log message
		if (myTarget.m_xpPerEnemyKilled < 0)
		{
			EditorGUILayout.HelpBox("L'experience ne peut pas être negative!", MessageType.Error);
		}
		// if xp goes under zero -> log message
		if (myTarget.m_enemiesKilled < 0)
		{
			EditorGUILayout.HelpBox("Le nombre d'ennemis ne peut pas être negatif!", MessageType.Info);
		}

		// Display player level
		int level = myTarget.m_experience / 150;
		EditorGUILayout.HelpBox(string.Format("Player is level {0}",level), MessageType.Info);

		//myTarget.m_xpPerEnemyKilled = EditorGUILayout.IntField("Xp per enemy killed", myTarget.m_xpPerEnemyKilled);
		//myTarget.m_enemiesKilled = EditorGUILayout.IntField("Enemies killed", myTarget.m_enemiesKilled);

	}
}
