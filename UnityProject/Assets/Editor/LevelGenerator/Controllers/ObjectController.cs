﻿using UnityEditor;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ObjectController
{
	/**
	 * An object controller responsible for providing a Singleton
	 * instance for KeyListener and Context. The Context is used to 
	 * attach objects to it; the Context can be used as:
	 *   ObjectController.GetContext.AddComponent<*component-class-name*>();
	 * 
	 * It also provides a way to get the currently selected game object.
	 */
	private static string contextName = "Level Generator Context";
	private static KeyListener keyListener = new KeyListener();

	public static GameObject GetContext()
	{
		GameObject go = GameObject.Find(contextName);
		if (go == null) 
			return new GameObject(contextName);
		
		return go;
	}

	public static void Move(float x, float y)
	{
		GameObject[] gameObjects = GetGameObjects();

		foreach (GameObject gameObject in gameObjects) 
		{
			IsometricPosition position = gameObject.GetComponent<IsometricPosition>();
			position.Set(position.x + x, position.y + y);
		}
	}

	public static void LightMove(float x, float y)
	{
		GameObject[] gameObjects = GetGameObjects();

		foreach (GameObject gameObject in gameObjects) 
		{
			Light lightObject = gameObject.GetComponentInChildren<Light>();

			if (lightObject == null) 
			{
				continue;
			}

			GameObject lightAttachedTo = lightObject.gameObject;

			Vector3 position = gameObject.transform.position;
			position.Set(position.x + x, position.y + y, position.z);
		}
	}
		
	// There is only one static key listener on ObjectController,
	// but more can be registered.
	public static KeyListener GetKeyListener()
	{
		return keyListener;
	}

	public static IsometricPosition GetPosition()
	{
		return GetGameObjects()[0].GetComponent<IsometricPosition> ();
	}

	public static GameObject[] GetGameObjects()
	{
		return Selection.gameObjects;
	}

	public static bool SelectedGameObject()
	{
		try 
		{
			var t = Selection.activeGameObject.name;
		}
		catch (Exception e)
		{
			return false;
		}
		return true;
	}
}

