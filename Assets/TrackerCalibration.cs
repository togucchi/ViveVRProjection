using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerCalibration : MonoBehaviour {
    Vector3 localPos;
    Quaternion localRot;
    Transform firstParent;

    bool calibrating = true;
	// Use this for initialization
	void Start () {
        localPos = transform.localPosition;
        localRot = transform.localRotation;
        firstParent = transform.parent;	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1))
        {
            calibrating = !calibrating;
        }

        if(calibrating)
        {
            transform.parent = firstParent;
            transform.localPosition = localPos;
            transform.localRotation = localRot;
        }
        else
        {
            transform.parent = null;
        }
	}
}
