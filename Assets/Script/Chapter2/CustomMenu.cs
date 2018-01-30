using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomMenu : MonoBehaviour {

	[MenuItem("MyCustomMenu/Hello World % h",false)]
	private static void SayHello()
	{
		Debug.Log("Hello World!");
	}

	[MenuItem("MyCustomMenu/GetObjectName")]
	private static void GetObjectName()
	{
		Debug.Log(Selection.activeTransform.gameObject.name);
	}
	[MenuItem("MyCustomMenu/GetObjectName",true)]
	private static bool CanGetObject()
	{
		return Selection.activeGameObject != null;
	}
	[MenuItem("GameObject/MyCustmMenu/CustomGameObject")]
	static void CreateCustomGameObject(MenuCommand menuCommand)
	{
		// Creation d'un nouveau gameobject
		GameObject go = new GameObject("Custom Game Object");

		//Renseigne le parent dans le cas d'une creation via le panneau hierarchie
		GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);

		// Enregistrement dans le systeme d'annulation pour pouvoir revenir en arriere
		Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);

		// Selectionne l'object cree
		Selection.activeObject = go;
	}
}
