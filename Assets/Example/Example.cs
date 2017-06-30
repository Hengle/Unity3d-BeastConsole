﻿using System.Collections;
using System.Collections.Generic;
using BeastConsole;
using UnityEngine;

public class Example : MonoBehaviour {

    public float TestVar = 0f;

	// Use this for initialization
	void Start () {
        //You need to provide a setter for a variable, and a reference to "owner".
        Console.RegisterVariable<float>("test","some test", x => TestVar = x, this );
        Console.RegisterCommand("MoveUp", "", this, MoveUp);
	}

    private void OnDestroy() {
        Console.UnregisterVariable<float>("test", this);
        Console.UnregisterCommand("MoveUp", this);
    }

    private void MoveUp(string[] val) {
        transform.position += new Vector3(0,System.Convert.ToSingle(val[1]), 0);
    }
}
