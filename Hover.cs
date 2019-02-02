using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {

	public Texture2D mouseDefault;
	public CursorMode curMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	// Use this for initialization
	void Start () {
        // Changes the mouse cursor using the users provided image
		Cursor.SetCursor (mouseDefault, hotSpot, curMode);
	}
}
