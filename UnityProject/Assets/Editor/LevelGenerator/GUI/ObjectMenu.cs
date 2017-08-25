﻿using UnityEditor;
using UnityEngine;
using GeneratorNS;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Serializers;

class ObjectMenu : IMenu
{
	/**
	 * ObjectMenu:
	 *   a menu used for attaching and detaching key listeners 
	 *   when an object is selected. It also provides a basic 
	 *   "inspector" which shows the X and Y coordinates.
	 */

	public ObjectMenu()
	{
	}

	public void Display()
	{
		if (ObjectController.SelectedGameObject ()) 
		{
			InternalObjectMenu ();
			RegisterKeyListeners ();
		} 
		else 
		{
			ClearKeyListeners ();
		}
	}


	private void ClearKeyListeners()
	{
		KeyListener keyListener = ObjectController.GetKeyListener ();
		keyListener.ClearKeys ();
	}

	private void RegisterKeyListeners()
	{
		KeyListener keyListener = ObjectController.GetKeyListener ();
		keyListener.ClearKeys ();

		Action<float, float> moveAction = (x, y) => ObjectController.Move(x, y);

		keyListener.RegisterKey (KeyCode.W, () => {
			Debug.Log("Up");
			moveAction(+1, 0);
		});
		keyListener.RegisterKey (KeyCode.A, () => {
			Debug.Log("Left");
			moveAction(0, +1);
		});
		keyListener.RegisterKey (KeyCode.S, () => {
			Debug.Log("Down");
			moveAction(-1, 0);
		});
		keyListener.RegisterKey (KeyCode.D, () => {
			Debug.Log("Right");
			moveAction(0, -1);
		});
	}

	private void InternalObjectMenu()
	{
		EditorGUILayout.LabelField ("", GUI.skin.horizontalSlider);

		GameObject go = ObjectController.GetGameObjects()[0];

		GUILayout.Label("Use W, A, S, D to move objects once they are selected.");

		GUILayout.BeginHorizontal ();
		IsometricPosition pos = ObjectController.GetPosition();

		GUILayout.Label("Current selected object: " + go.name);

		if (pos != null) 
		{
			float X = pos.x;
			float Y = pos.y;

			GUILayout.Label ("X:");
			X = EditorGUILayout.FloatField (X, GUILayout.MaxWidth (30));
			GUILayout.Label ("Y:");
			Y = EditorGUILayout.FloatField (Y, GUILayout.MaxWidth (30));

			pos.Set (X, Y);
		}

		GUILayout.EndHorizontal ();
	}

}