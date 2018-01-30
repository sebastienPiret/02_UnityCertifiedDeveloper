using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AllFieldsItem))]
public class AllFieldsEditor : Editor {

	public override void OnInspectorGUI()
	{
		EditorGUILayout.IntField("Int", 40);
		EditorGUILayout.DoubleField("Double", 100);
		EditorGUILayout.LongField("Long", 1234567890123456789);
		EditorGUILayout.FloatField("Float", 100.45f);

		EditorGUILayout.ColorField("Color", new Color());
		EditorGUILayout.CurveField("Curve", new AnimationCurve());

		EditorGUILayout.TextField("Text", "L'éditeur est vraiment très pratique !");
		EditorGUILayout.PasswordField("Password", "unity3d");
		EditorGUILayout.LabelField("Label", "Un texte neutre");

		EditorGUILayout.LayerField("Layer", 1);
		EditorGUILayout.TagField("Tag", "Player");

		EditorGUILayout.MaskField("Mask", 1, new[] { "Mask1", "Mask2" });
		EditorGUILayout.EnumMaskField("Enum Mask", MessageType.Info);

		EditorGUILayout.RectField("Rect", new Rect(3, 2, 0, 1));
		EditorGUILayout.BoundsField("Bounds", new Bounds(Vector3.zero, Vector3.one));

		EditorGUILayout.Vector2Field("Vector2", new Vector2(40, 22.4f));
		EditorGUILayout.Vector3Field("Vector3", new Vector3(1, 2, -3));
		EditorGUILayout.Vector4Field("Vector4", new Vector4(22, 0.4f, -123, 0));
	}
}

